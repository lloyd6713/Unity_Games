using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointTrading : MonoBehaviour
{

    public Text Point, PointGoal;
    public GameObject GamePoints;
    public AudioSource PointLose;
    public int Points = 0;
    private int Goal = 50;

    private void OnMouseDown()
    {
        GamePoints.SetActive(true);
        GameObject.Find("Player").GetComponent<PlayerMove>().Sensitivity = 0f;
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        Point.text = "Points: " + Points.ToString();
        PointGoal.text = "Goal: " + Goal.ToString();

        if (Points > Goal)
        {
            PointLose.Play();
            Goal += 100;
        }
    }
}
