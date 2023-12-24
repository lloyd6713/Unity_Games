using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchGround : MonoBehaviour
{
    public GameObject ls;

    void Update() {
        if (GameObject.Find("Items").GetComponent<items>().StopGame && this.name == "Meator(Clone)") {
            transform.position = new Vector3(10000f, -1000f);
            Destroy(GameObject.Find(this.name));
        }
    }

    void OnTriggerEnter2D(Collider2D other2d) {
        if (this.name != "Meator" && other2d.name == "Ground") {
            GameObject.Find("Items").GetComponent<items>().StopGame = true;
            ls.SetActive(true);
        }
    }
}
