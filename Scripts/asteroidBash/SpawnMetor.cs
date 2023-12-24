using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMetor : MonoBehaviour
{


    public int TimeToSpawn;
    public int TimeToSpawnRandom;
    public int TimeSpawn;
    public bool CanSpawn;

    public GameObject Metor;
    public Transform AsteroidParent;

        
    // Start is called before the first frame update
    void Start()
    {
        TimeToSpawnRandom = Random.Range(TimeToSpawn - 3, TimeToSpawn + 3);
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpawn++;
        if (TimeSpawn > (TimeToSpawnRandom * 30) && CanSpawn) {
            SpawnMetaor();
            TimeSpawn = 0;
            TimeToSpawnRandom = Random.Range(TimeToSpawn - 3, TimeToSpawn + 3);
        }
    }

    void SpawnMetaor() {
        GameObject Clone = Instantiate(Metor);
        Clone.transform.position = new Vector3(Random.Range(-6.47f, 4.11f), transform.position.y, 0f);
        float radiusMet = Random.Range(1, 3);
        Clone.transform.localScale = new Vector3(radiusMet, radiusMet, 0f);
        Clone.transform.parent = AsteroidParent.transform;
    }
}
