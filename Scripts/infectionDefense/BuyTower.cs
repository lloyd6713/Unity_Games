using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyTower : MonoBehaviour
{
    public TowerTracker TowerHolder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyTower1()
    {
        if (GameObject.Find("Money Manager").GetComponent<Money>().MoneyInt >= 25)
        {
            GameObject.Find("Money Manager").GetComponent<Money>().MoneyInt = GameObject.Find("Money Manager").GetComponent<Money>().MoneyInt - 25;
            TowerHolder.Tower1 = TowerHolder.Tower1 + 1;
        }
    }


    public void BuyTower2()
    {
        if (GameObject.Find("Money Manager").GetComponent<Money>().MoneyInt >= 50)
        {
            GameObject.Find("Money Manager").GetComponent<Money>().MoneyInt = GameObject.Find("Money Manager").GetComponent<Money>().MoneyInt - 50;
            TowerHolder.Tower2 = TowerHolder.Tower2 + 1;
        }
    }


    public void BuyMingun()
    {
        if (GameObject.Find("Money Manager").GetComponent<Money>().MoneyInt >= 100)
        {
            GameObject.Find("Money Manager").GetComponent<Money>().MoneyInt = GameObject.Find("Money Manager").GetComponent<Money>().MoneyInt - 100;
            TowerHolder.Mingun = TowerHolder.Mingun + 1;
        }
    }
}
