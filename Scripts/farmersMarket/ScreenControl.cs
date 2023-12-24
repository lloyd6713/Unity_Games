using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenControl : MonoBehaviour
{
    public GameObject MainScreen, SettingsScreen;
    public Slider VolumeSlide;
    public InventoeyManager IM;
    public PlayerMove PM;


    public void StartGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        RemoveMain();
        RemoveSettings();
    }

    public void RemoveMain()
    {
        MainScreen.SetActive(false);
    }

    public void RemoveSettings()
    {
        SettingsScreen.SetActive(false);
    }

    public void OpenMain()
    {
        MainScreen.SetActive(true);
        RemoveSettings();
    }

    public void OpenSettings()
    {
        SettingsScreen.SetActive(true);
        MainScreen.SetActive(false);
    }


    public void Restart()
    {
        PM.money = 0;
        IM.RemoveItem(1);
        IM.RemoveItem(2);
        IM.RemoveItem(3);
        IM.RemoveItem(4);
        IM.GetItem(IM.CarrotSeeds, "Carrot Seeds");
    }   

    public void Slide()
    {
        AudioListener.volume = VolumeSlide.value;
    }

}
