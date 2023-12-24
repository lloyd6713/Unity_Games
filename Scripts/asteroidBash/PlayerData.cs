using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int BestScore;
    public int Points;
    public int Multiplier;
    public int TimeStops;

   

    public void SavePlayerDataViaScript1()
    {
        BestScore = PlayerPrefs.GetInt("Best Score");
        Multiplier = PlayerPrefs.GetInt("Multiplier");
        Points = PlayerPrefs.GetInt("Points");
        TimeStops = PlayerPrefs.GetInt("Time Stop");
        
        SaveAndLoad.SavePlayerData(this);
    }

    public void LoadPlayerDataViaScript1()
    {
        SavePlayer sp = SaveAndLoad.LoadPlayerData();

        BestScore = sp.BestScore;
        Points = sp.Points;
        Multiplier = sp.Multiplier;
        TimeStops = sp.TimeStops;
    }
}
