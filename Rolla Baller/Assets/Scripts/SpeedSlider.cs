using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedSlider : MonoBehaviour
{
    public Slider speedSlider;
    public static float sliderValue = 1f;
    public Text sliderText;

    void Start()
    {
        
    }

    void Update()
    {
        sliderValue = speedSlider.value;
        sliderText.text = speedSlider.value.ToString();
        Rotator.speed = sliderValue;
        PlayerPrefs.SetFloat("SliderValue", sliderValue);
    }
    void ChangeSlider()
    {

    }
}
