using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAsteriod : MonoBehaviour
{

    public AudioSource Explosion;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Meator(Clone)") {
            Explosion.Play();
            GameObject.Find("Score Tracker").GetComponent<ScoreTrack>().ScoreNUM = GameObject.Find("Score Tracker").GetComponent<ScoreTrack>().ScoreNUM + 1;
            GameObject.Find(other.name).GetComponent<Rigidbody2D>().MovePosition(new Vector3(10000f, 100f, 0f));
            GetComponent<Rigidbody2D>().MovePosition(new Vector2(1000f, 100f));
            Destroy(other.gameObject);
            Destroy(GameObject.Find(this.name));
        }
    }
}
