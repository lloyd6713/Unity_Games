using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [System.Serializable]
public class SavePlayer {
    
    public int BestScore;
    public int Points;
    public int Multiplier;
    public int TimeStops;

    public SavePlayer(PlayerData playerdata)
    {
        BestScore = playerdata.BestScore;
        Points = playerdata.Points;
        Multiplier = playerdata.Multiplier;
        TimeStops = playerdata.TimeStops;

    }
}
