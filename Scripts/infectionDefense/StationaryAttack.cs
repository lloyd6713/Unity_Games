using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryAttack : MonoBehaviour
{
    private float Distance;
    private float beforeDistance = 100000f;

    public GameObject Enemy;
    public GameObject AllEnimies;
    public GameObject SelectedEnemy;
    public GameObject Knife;
    public float Range = 3f;
    public int Damage;

    private int CountDownAttackingTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        Ray RaycastRay = new Ray(transform.position, transform.forward);
        CountDownAttackingTime++;
        if (CountDownAttackingTime > 60) {
            if (Physics.Raycast(RaycastRay, out hit, Range))
            {
                hit.collider.gameObject.GetComponent<EnemyAI>().Health = hit.collider.gameObject.GetComponent<EnemyAI>().Health - Damage;
                GameObject.Find("Money Manager").GetComponent<Money>().MoneyInt = GameObject.Find("Money Manager").GetComponent<Money>().MoneyInt + hit.collider.gameObject.GetComponent<EnemyAI>().MoneyGiven;
            }
            CountDownAttackingTime = 0;
        }

        Debug.DrawLine(transform.position, transform.forward * Range, Color.green);
    }
}
