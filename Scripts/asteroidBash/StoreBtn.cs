using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StoreBtn : MonoBehaviour
{

    public GameObject StoreEmpty;
    public Text Points;

    public void Open()
    {
        StoreEmpty.SetActive(true);
    }
    public void Close()
    {
        StoreEmpty.SetActive(false);
    }

    private void Update()
    {
        Points.text = "Points: " + PlayerPrefs.GetInt("Points");
    }
}