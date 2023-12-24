using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HarvestPlant : MonoBehaviour
{

    [Space]

    public Texture Carrot, Tomato, Pumpkin, Eggplant, Potota, Onion;
    public GameObject Dirt, TomatoVinesStage2, PumpkinVineSt2, EggplantVineSt2;
    public InventoeyManager InventoryManager;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out hit, 100f))
            {
                if (hit.collider.gameObject.name == "DirtCarrot(Clone)")
                {
                    InventoryManager.GetItem(Carrot, "Carrot");
                    Vector3 PlacePoint = hit.collider.gameObject.transform.position;
                    Destroy(hit.collider.gameObject);
                    GameObject DirtPile = Instantiate(Dirt);
                    DirtPile.transform.position = PlacePoint;
                } else if (hit.collider.gameObject.name == "TomatoFinal(Clone)")
                {
                    InventoryManager.GetItem(Tomato, "Tomato");
                    Vector3 PlacePoint = hit.collider.gameObject.transform.position;
                    Destroy(hit.collider.gameObject);
                    GameObject TomatoVine = Instantiate(TomatoVinesStage2);
                    TomatoVine.transform.position = PlacePoint;
                } else if (hit.collider.gameObject.name == "PumpkinVineFinal(Clone)")
                {
                    InventoryManager.GetItem(Pumpkin, "Pumpkin");
                    Vector3 PlacePoint = hit.collider.gameObject.transform.position;
                    Destroy(hit.collider.gameObject);
                    GameObject PumpkinVine = Instantiate(PumpkinVineSt2);
                    PumpkinVine.transform.position = PlacePoint;
                } else if (hit.collider.gameObject.name == "StageFinalEggPlant(Clone)")
                {
                    InventoryManager.GetItem(Eggplant, "Eggplant");
                    Vector3 PlacePoint = hit.collider.gameObject.transform.position;
                    Destroy(hit.collider.gameObject);
                    GameObject PumpkinVine = Instantiate(EggplantVineSt2);
                    PumpkinVine.transform.position = PlacePoint;
                } else if (hit.collider.gameObject.name == "OnionStageFinal(Clone)")
                {
                    InventoryManager.GetItem(Onion, "Onion");
                    Vector3 PlacePoint = hit.collider.gameObject.transform.position;
                    Destroy(hit.collider.gameObject);
                    GameObject DirtLeft = Instantiate(Dirt);
                    DirtLeft.transform.position = PlacePoint;
                } else if (hit.collider.gameObject.name == "PototaStageFinal(Clone)")
                {
                    InventoryManager.GetItem(Potota, "Potota");
                    Vector3 PlacePoint = hit.collider.gameObject.transform.position;
                    Destroy(hit.collider.gameObject);
                    GameObject DirtLeft = Instantiate(Dirt);
                    DirtLeft.transform.position = PlacePoint;
                } 
            }
        }
    }
}
