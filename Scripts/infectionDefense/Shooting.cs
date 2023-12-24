using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("Shooting Settings")]
    public int Damage = 1;
    public int ShootingTimeSeconds;
    public float Range = 100f;

    public GameObject WhereToShootFrom;
    public GameObject Enemy;
    public GameObject AllEnimies;
    public GameObject SelectedEnemy;
    public ParticleSystem Flash;
    private int CountDownShootingTime; 
    private float Distance;
    private float beforeDistance = 100000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print (AllEnimies.transform.childCount);
        for (int i = 0; i < AllEnimies.transform.childCount; i++) 
        {
            if (i == 0)
            {
                beforeDistance = 100000f;
            }
            Enemy = AllEnimies.transform.GetChild(i).gameObject;
            Distance = Mathf.Abs((Enemy.transform.position - transform.position).x) + Mathf.Abs((Enemy.transform.position - transform.position).y) + Mathf.Abs((Enemy.transform.position - transform.position).z);
            print (Distance < beforeDistance);
            if (Distance < beforeDistance) 
            {
                beforeDistance = Distance;
                SelectedEnemy = Enemy;
            }

        }
        if (Distance < Range) 
        {
            Enemy = SelectedEnemy;
        } else {
            Enemy = null;
        }
        if (Enemy != null) {
            transform.LookAt(Enemy.transform);
        }
        RaycastHit hit;
        Ray RaycastRay = new Ray(WhereToShootFrom.transform.position, transform.forward);
        CountDownShootingTime++;
        if (CountDownShootingTime > (ShootingTimeSeconds * 30)) {
            if (Physics.Raycast(RaycastRay, out hit, Range)) 
            {
                Debug.DrawLine(WhereToShootFrom.transform.position, transform.forward * Range, Color.green);
                Flash.Play();
                hit.collider.gameObject.GetComponent<EnemyAI>().Health = hit.collider.gameObject.GetComponent<EnemyAI>().Health - Damage;
                GameObject.Find("Money Manager").GetComponent<Money>().MoneyInt = GameObject.Find("Money Manager").GetComponent<Money>().MoneyInt + hit.collider.gameObject.GetComponent<EnemyAI>().MoneyGiven;
            }
            CountDownShootingTime = 0;
        }
    }

    

    
}
