using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BtnMode : MonoBehaviour
{

    public SpawnEnemies SE;
    public EnemyAI ESpeedy, EHidden, E, B1, B1Hidden, B1Speedy, B2, B3;
    public Money M;
    public GameObject GameScreen;
    public Transform Enemies;

    public void Easy()
    {
        ESpeedy.Health = 5;
        EHidden.Health = 1;
        E.Health = 5;
        B1.Health = 20;
        B1Hidden.Health = 10;
        B1Speedy.Health = 20;
        B2.Health = 40;
        B3.Health = 100;
        M.MoneyInt = 100;
        SE.Start = true;
        Screen();
    }

    public void Normal()
    {
        ESpeedy.Health = 10;
        EHidden.Health = 2;
        E.Health = 10;
        B1.Health = 40;
        B1Hidden.Health = 20;
        B1Speedy.Health = 40;
        B2.Health = 80;
        B3.Health = 200;
        M.MoneyInt = 100;
        SE.Start = true;
        Screen();
    }

    public void Hard()
    {
        ESpeedy.Health = 10;
        EHidden.Health = 2;
        E.Health = 10;
        B1.Health = 40;
        B1Hidden.Health = 20;
        B1Speedy.Health = 40;
        B2.Health = 80;
        B3.Health = 200;
        M.MoneyInt = 50;
        SE.Start = true;
        Screen();
    }

    void Screen()
    {
        GameScreen.SetActive(true);

        GameObject.Find("Reg Screen").SetActive(false);

    }


    public void Escape()
    {
        SceneManager.LoadScene("BossStage1Done");
    }

    
}
