using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{


    public int Health = 5;
    public int MoneyGiven = 5;
    public float Speed = 7f;
    public int Damage = 1;
    public bool Moving = false;
    public bool Hidden = false;
    public bool Boss;
    public int BossHealth;
    public Transform EnemyTypes;
    public Transform[] Targets;
    public int CurrentTarget = 0;
    public GameObject Body, Arm1, Arm2, Leg1, Leg2;
    public Material Cloth;
    public Material Arm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0) 
        {   
            if (!Hidden) {
                GameObject.Find("Enemy Spawner").GetComponent<SpawnEnemies>().EnemiesLeftInWave = GameObject.Find("Enemy Spawner").GetComponent<SpawnEnemies>().EnemiesLeftInWave - 1;
                GameObject.Find("Enemy Spawner").GetComponent<SpawnEnemies>().EnemiesLeftInWave = GameObject.Find("Enemy Spawner").GetComponent<SpawnEnemies>().EnemiesLeftInWave - 1;
                Destroy(this.gameObject);
            } else {
                //GameObject Clone = Instantiate(EnemyTypes.GetChild(Random.Range(0, 1)).gameObject);
                //Clone.transform.position = transform.position;
                //Clone.transform.parent = GameObject.Find("All Enemies").transform;
                //Destroy(this.gameObject);
                Hidden = false;
                if (!Boss)
                {
                    Health = 10;
                } else {
                    Health = BossHealth;
                }
                Body.GetComponent<MeshRenderer>().material = Cloth;
                Arm1.GetComponent<MeshRenderer>().material = Arm;
                Arm2.GetComponent<MeshRenderer>().material = Arm;
                Leg1.GetComponent<MeshRenderer>().material = Arm;
                Leg2.GetComponent<MeshRenderer>().material = Arm;


            }
        }

        if (Moving) {
            transform.LookAt(Targets[CurrentTarget]);
            GetComponent<Rigidbody>().velocity = transform.forward * Speed;
            if (Mathf.Abs((Targets[CurrentTarget].position - transform.position).x) + Mathf.Abs((Targets[CurrentTarget].position - transform.position).y) + Mathf.Abs((Targets[CurrentTarget].position - transform.position).z) < 1f) 
            {
                CurrentTarget++;
            }
        }

        if (CurrentTarget == 14)
        {
            GameObject.Find("Health Manager").GetComponent<HealthManager>().Health = GameObject.Find("Health Manager").GetComponent<HealthManager>().Health - Damage;
            GameObject.Find("Enemy Spawner").GetComponent<SpawnEnemies>().EnemiesLeftInWave = GameObject.Find("Enemy Spawner").GetComponent<SpawnEnemies>().EnemiesLeftInWave - 1;
            GameObject.Find("Enemy Spawner").GetComponent<SpawnEnemies>().EnemiesLeftInWave = GameObject.Find("Enemy Spawner").GetComponent<SpawnEnemies>().EnemiesLeftInWave - 1;
            Destroy(this.gameObject);
        }
    }
}
