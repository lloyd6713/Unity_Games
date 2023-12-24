using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Text HealthText;
    public Text WinLose;
    public int Health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = "Health: " + Health;
        if (Health <= 0)
        {
            WinLose.text = "You Lose!";
        }
    }
}
