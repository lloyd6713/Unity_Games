using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerTimeWait : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Time Stop") > 0 && Input.GetKeyDown(KeyCode.X))
        {
            GameObject.Find("SpawnMetor").GetComponent<SpawnMetor>().CanSpawn = false;
            StartCoroutine(waiter());
        }
    }


    IEnumerator waiter()
    {

    //Wait for 2 seconds
    yield return new WaitForSeconds(2f);
    yield return new WaitForSeconds(2f);

    GameObject.Find("SpawnMetor").GetComponent<SpawnMetor>().CanSpawn = true;
    PlayerPrefs.SetInt("Time Stop", PlayerPrefs.GetInt("Time Stop") - 1);


    
    
     }
}
