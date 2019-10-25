using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rounds : MonoBehaviour
{
    public static int rounds = 0;
    public Dropdown myDropdown;

    // Update is called once per frame
    void Update()
    {
        switch(myDropdown.value)
        {
            case 1:
                rounds = 1;
                break;
            case 2:
                rounds = 2;
                break;
            case 3:
                rounds = 3;
                break;
        }
        PlayerPrefs.SetInt("rounds", rounds);
    }
}
