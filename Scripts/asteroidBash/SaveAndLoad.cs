using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveAndLoad {

    public static void SavePlayerData(PlayerData pd)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/player.code";
        FileStream stream = new FileStream(path, FileMode.Create);

        SavePlayer playerSaved = new SavePlayer(pd);

        formatter.Serialize(stream, playerSaved);
        stream.Close();
    }

    public static SavePlayer LoadPlayerData()
    {
        string path = Application.persistentDataPath + "/player.code";
        if (File.Exists(path))
        {   
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Open);

            SavePlayer playerSaved = formatter.Deserialize(stream) as SavePlayer;
            stream.Close();

            return playerSaved;
        } else {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
