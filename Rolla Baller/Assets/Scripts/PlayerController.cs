using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 800.0f;
    public Text scoreText;
    private static int count = 0;
    public Text winText;
    private static int highscore = 0;
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    public GameObject pickUps1;
    public GameObject pickUps2;
    public GameObject pickUps3;
    public GameObject pickUps4;
    public GameObject pickUps5;
    public GameObject pickUps6;
    public GameObject pickUps7;
    public GameObject pickUps8;
    public int rounds = 0;

    void Awake()
    {
        count = 0;
        MusicSource.clip = MusicClip;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        speed = PlayerPrefs.GetFloat("BallSpeed");

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
        rounds = PlayerPrefs.GetInt("rounds");
        if (rounds == 1)
        {
            if (count == 8)
            {
                winText.gameObject.SetActive(true);
            }
        }
        if (rounds == 2)
        {
            if (count == 16)
            {
                 winText.gameObject.SetActive(true);
            }
            if (count == 8)
            {
                pickUps1.SetActive(true);
                pickUps2.SetActive(true);
                pickUps3.SetActive(true);
                pickUps4.SetActive(true);
                pickUps5.SetActive(true);
                pickUps6.SetActive(true);
                pickUps7.SetActive(true);
                pickUps8.SetActive(true);
            }

        }
        if (rounds == 3)
        {
            if (count == 24)
            {
                winText.gameObject.SetActive(true);
            }
            if (count == 8)
            {
                pickUps1.SetActive(true);
                pickUps2.SetActive(true);
                pickUps3.SetActive(true);
                pickUps4.SetActive(true);
                pickUps5.SetActive(true);
                pickUps6.SetActive(true);
                pickUps7.SetActive(true);
                pickUps8.SetActive(true);
            }
            if (count == 16)
            {
                pickUps1.SetActive(true);
                pickUps2.SetActive(true);
                pickUps3.SetActive(true);
                pickUps4.SetActive(true);
                pickUps5.SetActive(true);
                pickUps6.SetActive(true);
                pickUps7.SetActive(true);
                pickUps8.SetActive(true);
            }
        }
        PlayerPrefs.SetInt("rounds", rounds);
        PlayerPrefs.SetInt("Score", count);
        if (count > highscore)
        {
            highscore = count;
        }
        scoreText.text = "Score: " + count;
        PlayerPrefs.SetInt("HighScore", highscore);

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;
            MusicSource.Play();
        }
    }
}
