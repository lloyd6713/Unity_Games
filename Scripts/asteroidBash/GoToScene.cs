using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoToScene : MonoBehaviour
{
    public GameObject SceneObject;
    public GameObject Main;
    public Text bestScoreTxt;
    public Text YourScoreTxt;

    public int bestScore;
    public int sceneNum;


    public void Start() {
       
    }

    public void Update() {
        if (GameObject.Find("Score Tracker").GetComponent<ScoreTrack>().ScoreNUM > bestScore) {
            PlayerPrefs.SetInt("Best Score", GameObject.Find("Score Tracker").GetComponent<ScoreTrack>().ScoreNUM);
        }
        bestScore = PlayerPrefs.GetInt("Best Score");
        bestScoreTxt.text = "Best Score: " + bestScore;
        YourScoreTxt.text = "Your Score: " +  GameObject.Find("Score Tracker").GetComponent<ScoreTrack>().ScoreNUM;
        
    }

    public void GoToSceneNumObject() {
        if (sceneNum == 0) {
            SceneObject.SetActive(false);
            Main.SetActive(true);
            PlayerPrefs.SetInt("Points", (GameObject.Find("Score Tracker").GetComponent<ScoreTrack>().ScoreNUM * PlayerPrefs.GetInt("Multiplier"))  + PlayerPrefs.GetInt("Points"));
            GameObject.Find("Score Tracker").GetComponent<ScoreTrack>().ScoreNUM = 0;
        } else if (sceneNum == 1) {
            SceneObject.SetActive(false);
            GameObject.Find("Items").GetComponent<items>().StopGame = false;
            
        }
    }

    
}
