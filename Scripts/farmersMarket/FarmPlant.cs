using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmPlant : MonoBehaviour
{

    public InventoeyManager InventoryManager;

    private Vector3 hitPoint;
    private GameObject DirtShoveled;

    public GameObject CarrotInGround, tomatoGrowing, PumpkinVineSt1, EggplantSt1, PototaGrowing, OnionGrowing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out hit, 100f))
            {
                hitPoint = hit.point;
                if (hit.collider.gameObject.name == "Dirt(Clone)")
                {
                    if (hit.collider.gameObject.GetComponent<DirtAttributes>().Watered)
                    {
                        DirtShoveled = hit.collider.gameObject;
                        StartFarmMethod();
                    }
                }
            }
        }
    }


    private void StartFarmMethod()
    {
        if (InventoryManager.ItemsInHotbar[InventoryManager.CurrentSelectedItem] == "Carrot Seeds")
        {
            Destroy(DirtShoveled);
            GameObject CarrotPlantedDirt = Instantiate(CarrotInGround);
            CarrotPlantedDirt.transform.position = hitPoint;
            InventoryManager.RemoveItem(InventoryManager.CurrentSelectedItem);
        } else if (InventoryManager.ItemsInHotbar[InventoryManager.CurrentSelectedItem] == "Tomato Seeds")
        {
            Destroy(DirtShoveled);
            GameObject TomatoPlantedDirt = Instantiate(tomatoGrowing);
            TomatoPlantedDirt.transform.position = hitPoint;
            InventoryManager.RemoveItem(InventoryManager.CurrentSelectedItem);
        } else if (InventoryManager.ItemsInHotbar[InventoryManager.CurrentSelectedItem] == "Pumpkin Seeds")
        {
            Destroy(DirtShoveled);
            GameObject PumpkinPlantedDirt = Instantiate(PumpkinVineSt1);
            PumpkinPlantedDirt.transform.position = hitPoint;
            InventoryManager.RemoveItem(InventoryManager.CurrentSelectedItem);
        } else if (InventoryManager.ItemsInHotbar[InventoryManager.CurrentSelectedItem] == "Eggplant Seeds")
        {
            Destroy(DirtShoveled);
            GameObject EggplantPlantedDirt = Instantiate(EggplantSt1);
            EggplantPlantedDirt.transform.position = hitPoint;
            InventoryManager.RemoveItem(InventoryManager.CurrentSelectedItem);
        } else if (InventoryManager.ItemsInHotbar[InventoryManager.CurrentSelectedItem] == "Onion Seeds")
        {
            Destroy(DirtShoveled);
            GameObject OnionPlantedDirt = Instantiate(OnionGrowing);
            OnionPlantedDirt.transform.position = hitPoint;
            InventoryManager.RemoveItem(InventoryManager.CurrentSelectedItem);
        } else if (InventoryManager.ItemsInHotbar[InventoryManager.CurrentSelectedItem] == "Potota Seeds")
        {
            Destroy(DirtShoveled);
            GameObject PototaPlantedDirt = Instantiate(PototaGrowing);
            PototaPlantedDirt.transform.position = hitPoint;
            InventoryManager.RemoveItem(InventoryManager.CurrentSelectedItem);
        }
    }
}
