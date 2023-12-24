using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStop : MonoBehaviour
{

    public Transform AsteroidParent;

    public void Update()
    {
        
        
        if (PlayerPrefs.GetInt("Time Stop") > 0 &&  this.gameObject.name == "Meator(Clone)" && Input.GetKeyDown(KeyCode.X))
        {
            GetComponent<Rigidbody2D>().gravityScale = 0f;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezePositionX;
            GameObject.Find("SpawnMetor").GetComponent<SpawnMetor>().CanSpawn = false;
            StartCoroutine(waiter());
        }
        
    }


    IEnumerator waiter()
    {

    //Wait for 2 seconds
    yield return new WaitForSeconds(2f);
    yield return new WaitForSeconds(2f);


    GetComponent<Rigidbody2D>().gravityScale = 0.45f;
    
    GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
    GameObject.Find("SpawnMetor").GetComponent<SpawnMetor>().CanSpawn = true;


    
    
     }
}
