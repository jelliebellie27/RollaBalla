using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallSpeedSlider : MonoBehaviour
{
    public static float speed = 800;
    public Slider BallSlider;
    public Text BallSliderText;

    void Update()
    {
        BallSliderText.text = BallSlider.value.ToString();
        speed = BallSlider.value;
        PlayerPrefs.SetFloat("BallSpeed", speed);
    }
}
