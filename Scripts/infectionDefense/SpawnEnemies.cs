using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemies : MonoBehaviour
{

    public int Wave;
    public int[] EnimiesInWave;
    public int[] SpeedyInWave;
    public int[] HiddenInWave;

    public int[] BossesStage1;
    public int[] BossesStage1Speedy;
    public int[] BossesStage1Hidden;


    public int[] BossesStage2;
    public int[] BossesStage3;


    public GameObject Enemy, SpeedyEnemy, HiddenEnemy;
    public Text WaveText;
    public bool Start;
    public GameObject AllEnimies;
    public GameObject BossStage1, BossStage2, BossStage3;
    public GameObject BossSt1Hidden, BossSt1Speedy;
    private int SpawnTime;
    private int BossesStage1Made, BossesStage2Made, BossesStage3Made;
    public int EnemiesLeftInWave;
    private int SpeedyEnemiesMade, HiddenEnemiesMade;
    private int BossesStage1MadeHidden, BossesStage1SpeedyMade;
    private int EnimeiesSpawned = 0;
    public Text WInLOse;

    // Start is called before the first frame update
    

    void Update()
    {
        if (Start) Spawn();
    }

    // Update is called once per frame
    void Spawn()
    {
        if (EnimeiesSpawned < EnimiesInWave[Wave]) 
        {
            
            SpawnTime++;
            if (SpawnTime == 150) {
                SpawnEnemy();
                SpawnTime = 0;
                EnimeiesSpawned++;
                EnemiesLeftInWave++;
            }
        } else if (SpeedyEnemiesMade < SpeedyInWave[Wave]) {
            SpawnTime++;
            if (SpawnTime == 150)
            {
                SpawnSpeedyEnemy();
                SpawnTime = 0;
                EnimeiesSpawned++;
                SpeedyEnemiesMade++;
            }
 
        } else if(HiddenEnemiesMade < HiddenInWave[Wave]) 
        {
            SpawnTime++;
            if (SpawnTime == 150)
            {
                SpawnHiddenEnemy();
                SpawnTime = 0;
                EnimeiesSpawned++;
                HiddenEnemiesMade++;
            }
        } else if (BossesStage1Made < BossesStage1[Wave]) 
        {
            SpawnTime++;
            if (SpawnTime == 150) {
                SpawnBossStage1();
                SpawnTime = 0;
                BossesStage1Made++;
                EnimeiesSpawned++;
            }
        } else if (BossesStage2Made < BossesStage2[Wave]) 
        {
            SpawnTime++;
            if (SpawnTime == 150) {
                SpawnBossStage2();
                SpawnTime = 0;
                BossesStage2Made++;
                EnimeiesSpawned++;
            }
        } else if (BossesStage1SpeedyMade < BossesStage1Speedy[Wave]) 
        {
            SpawnTime++;
            if (SpawnTime == 150) {
                SpawnBossStage1Speedy();
                SpawnTime = 0;
                BossesStage1SpeedyMade++;
                EnimeiesSpawned++;
            }
        } else if (BossesStage1MadeHidden < BossesStage1Hidden[Wave]) 
        {
            SpawnTime++;
            if (SpawnTime == 150) {
                SpawnBossStage1Hidden();
                SpawnTime = 0;
                BossesStage1MadeHidden++;
                EnimeiesSpawned++;
            }
        } else if (BossesStage3Made < BossesStage3[Wave]) 
        {
            SpawnTime++;
            if (SpawnTime == 150) {
                SpawnBossStage3();
                SpawnTime = 0;
                BossesStage3Made++;
                EnimeiesSpawned++;
            }
        }
        if (EnemiesLeftInWave == 0)
        {
            Wave++;
            EnimeiesSpawned = 0;
            EnemiesLeftInWave = EnimiesInWave[Wave];
        }

        WaveText.text = "Wave: " + Wave;
        if (Wave == 26)
        {
            Start = false;
            WInLOse.text = "You Win!!!";
        }
    }

    void SpawnEnemy() 
    {
        GameObject Clone = Instantiate(Enemy);
        Clone.transform.position = transform.position;
        Clone.transform.parent = AllEnimies.transform;
        Clone.GetComponent<EnemyAI>().Moving = true;
    }

    void SpawnBossStage1()
    {
        GameObject Clone = Instantiate(BossStage1);
        Clone.transform.position = transform.position;
        Clone.transform.parent = AllEnimies.transform;
        Clone.GetComponent<EnemyAI>().Moving = true;
    }

    void SpawnBossStage2()
    {
        GameObject Clone = Instantiate(BossStage2);
        Clone.transform.position = transform.position;
        Clone.transform.parent = AllEnimies.transform;
        Clone.GetComponent<EnemyAI>().Moving = true;
    }

    void SpawnBossStage3()
    {
        GameObject Clone = Instantiate(BossStage3);
        Clone.transform.position = transform.position;
        Clone.transform.parent = AllEnimies.transform;
        Clone.GetComponent<EnemyAI>().Moving = true;
    }

    void SpawnSpeedyEnemy()
    {
        GameObject Clone = Instantiate(SpeedyEnemy);
        Clone.transform.position = transform.position;
        Clone.transform.parent = AllEnimies.transform;
        Clone.GetComponent<EnemyAI>().Moving = true;
    }

    void SpawnHiddenEnemy()
    {
        GameObject Clone = Instantiate(HiddenEnemy);
        Clone.transform.position = transform.position;
        Clone.transform.parent = AllEnimies.transform;
        Clone.GetComponent<EnemyAI>().Moving = true;
    }

    void SpawnBossStage1Speedy()
    {
        GameObject Clone = Instantiate(BossSt1Speedy);
        Clone.transform.position = transform.position;
        Clone.transform.parent = AllEnimies.transform;
        Clone.GetComponent<EnemyAI>().Moving = true;
    }

    void SpawnBossStage1Hidden()
    {
        GameObject Clone = Instantiate(BossSt1Hidden);
        Clone.transform.position = transform.position;
        Clone.transform.parent = AllEnimies.transform;
        Clone.GetComponent<EnemyAI>().Moving = true;
    }

    
}
