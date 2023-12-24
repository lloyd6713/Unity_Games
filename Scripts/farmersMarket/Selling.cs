using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selling : MonoBehaviour
{
    public GameObject Sell;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnMouseDown()
    {
        Sell.SetActive(true);
        GameObject.Find("Player").GetComponent<PlayerMove>().Sensitivity = 0f;
        Cursor.lockState = CursorLockMode.None;
    }   
}
