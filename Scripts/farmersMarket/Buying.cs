using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buying : MonoBehaviour
{


    public GameObject Buy;


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
        Buy.SetActive(true);
        GameObject.Find("Player").GetComponent<PlayerMove>().Sensitivity = 0f;
        Cursor.lockState = CursorLockMode.None;
    }
}
