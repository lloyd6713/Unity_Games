using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmPlace : MonoBehaviour
{

    public GameObject Dirt;
    public Material WateredDirt; 
    public GameObject ToolEquiped, ToolNotUsed;
    public GameObject Shovel, WaterBucket;
    public AudioSource ShovelSound, WaterBucketSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ToolEquiped.SetActive(true);
        ToolNotUsed.SetActive(false);
        
        if (Input.GetButtonDown("Fire2"))
        {

            RaycastHit hit;
            Ray RaycastRay = new Ray(transform.position, transform.forward);

            if (Physics.Raycast(RaycastRay, out hit, 100f))
            {
                if (hit.collider.gameObject.name == "Dirt(Clone)" && ToolEquiped == WaterBucket)
                {       
                    WaterBucketSound.Play();             
                    hit.collider.gameObject.GetComponent<Renderer>().sharedMaterial = WateredDirt;
                    hit.collider.gameObject.GetComponent<DirtAttributes>().Watered = true;
                } else if (hit.collider.gameObject.name == "Ground" && ToolEquiped == Shovel)
                {
                    ShovelSound.Play();
                    GameObject Clone = Instantiate(Dirt);
                    Clone.transform.position = hit.point;
                }
            }
        }


        // Tool Switching 
        if (Input.GetKeyDown(KeyCode.X) && ToolEquiped == Shovel)
        {
            ToolEquiped = WaterBucket;
            ToolNotUsed = Shovel;
        } else if (Input.GetKeyDown(KeyCode.X) && ToolEquiped == WaterBucket)
        {
            ToolNotUsed = WaterBucket;
            ToolEquiped = Shovel;
        }
    }
}
