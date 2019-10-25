using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{
    public static string PlayerName;
    public InputField PlayerNameInput;
    public Text showPlayername;
    public Text rounds;
    public Text ballSpeed;
    public Text cubeSpeed;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        showPlayername.text = PlayerName;
        rounds.text = "Rounds: " + PlayerPrefs.GetInt("rounds");
        ballSpeed.text = "Ball Speed: " + PlayerPrefs.GetFloat("BallSpeed");
        cubeSpeed.text = "Cube Speed: " + PlayerPrefs.GetFloat("SliderValue");

    }
    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        showPlayername.text = PlayerName;
    }
    public void ShowNameFun()
    {
        showPlayername.text = PlayerName;
    }
}
