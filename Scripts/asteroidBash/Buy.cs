using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{

    private int x = 50000;
    private int y = 50;

    public Text Time;
    public Text Multiplier;

    public void Start()
    {
        // PlayerPrefs.SetInt("Multiplier", 1);
        // PlayerPrefs.SetInt("Time Stop", 0);
        // PlayerPrefs.SetInt("Best Score", 0);
        // PlayerPrefs.SetInt("Points", 0);


        // Use To Reset ALL Scores
    }

    public void BuyTimeStop()
    {
        if (PlayerPrefs.GetInt("Points") >= x)
        {
            PlayerPrefs.SetInt("Time Stop", 1 + PlayerPrefs.GetInt("Time Stop"));
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") - x);
            x =+ x;
            Time.text = "Time Stop:" + x;

        }
    }


    public void BuyMultiplier()
    {
        if (PlayerPrefs.GetInt("Points") >= y)
        {
            PlayerPrefs.SetInt("Multiplier", 1 + PlayerPrefs.GetInt("Multiplier"));
            PlayerPrefs.SetInt("Points", PlayerPrefs.GetInt("Points") - y);
            y += y;
            Multiplier.text = "Point Multiplier:" + y;

        }
    }

}
