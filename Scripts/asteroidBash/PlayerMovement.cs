using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public AudioSource GunShot;
    public GameObject Bullet;

    private float Horizontal;
    public float speed;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Items").GetComponent<items>().StopGame == false) {
            GetInputs();
            rb.velocity = new Vector2(Horizontal, 0f) * speed;

            if (Input.GetButtonDown("Fire1")) {
                Shoot();
            } 
        }
    }


    void GetInputs() {
        Horizontal = Input.GetAxis("Horizontal");
    }

    void Shoot() {
        GunShot.Play();
        GameObject Clone = Instantiate(Bullet);
        Clone.transform.position = transform.position + new Vector3(0f, 1f, 0f);
        //Clonetransform.parent = GameObject.Find("Beams").transform;
    }
}
