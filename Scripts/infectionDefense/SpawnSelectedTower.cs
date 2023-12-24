using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSelectedTower : MonoBehaviour
{
    public GameObject Tower1, Tower2, Mingun;
    public TowerTracker TowerHolder;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseDown() 
    {
        if (TowerHolder.Tower1 > 0) {
            GameObject Clone = Instantiate(Tower1);
            Clone.transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
            TowerHolder.Tower1 = TowerHolder.Tower1 - 1;
        } else if (TowerHolder.Tower2 > 0) {
            GameObject Clone = Instantiate(Tower2);
            Clone.transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
            TowerHolder.Tower2 = TowerHolder.Tower2 - 1;
        } else if (TowerHolder.Mingun > 0) {
            GameObject Clone = Instantiate(Mingun);
            Clone.transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
            TowerHolder.Mingun = TowerHolder.Mingun - 1;
        }
    }
}
