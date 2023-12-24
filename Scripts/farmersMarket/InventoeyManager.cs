using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoeyManager : MonoBehaviour
{

    public RawImage HotBarSlot1, HotBarSlot2, HotBarSlot3, HotBarSlot4;
    public Texture Empty;
    [Space]
    public GameObject HoveringInventoryPanel1, HoveringInventoryPanel2, HoveringInventoryPanel3, HoveringInventoryPanel4;
    public Texture CarrotSeeds, TomatoSeeds, PumpkinSeeds;
    public int CurrentSelectedItem = 1;
    public string[] ItemsInHotbar;
    private int slot;
    public int[] HotBarSlotItems;
    private bool EscapeKeyPressed;
    public Text HotBarSlot1Num, HotBarSlot2Num, HotBarSlot3Num, HotBarSlot4Num;


    // Start is called before the first frame update
    void Start()
    {
        ResetAllBoxes();
        HoveringInventoryPanel1.SetActive(true);
        GetItem(CarrotSeeds, "Carrot Seeds");
    }

    // Update is called once per frame
    void Update()
    {
        SelectItem();
        HotBarSlot1Num.text = HotBarSlotItems[1].ToString();
        HotBarSlot2Num.text = HotBarSlotItems[2].ToString();
        HotBarSlot3Num.text = HotBarSlotItems[3].ToString();
        HotBarSlot4Num.text = HotBarSlotItems[4].ToString();

        if (Input.GetKeyDown(KeyCode.Escape) && EscapeKeyPressed)
        {
            EscapeKeyPressed = false;
            Cursor.lockState = CursorLockMode.Locked; 
        } else if (Input.GetKeyDown(KeyCode.Escape) && !EscapeKeyPressed)
        {
            EscapeKeyPressed = true;
            Cursor.lockState = CursorLockMode.None; 
        }
    }


    private void SelectItem()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ResetAllBoxes();
            HoveringInventoryPanel4.SetActive(true);
            CurrentSelectedItem = 4;
        } else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ResetAllBoxes();
            HoveringInventoryPanel3.SetActive(true);
            CurrentSelectedItem = 3;
        } else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ResetAllBoxes();
            HoveringInventoryPanel1.SetActive(true);
            CurrentSelectedItem = 1;
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ResetAllBoxes();
            HoveringInventoryPanel2.SetActive(true);
            CurrentSelectedItem = 2;
        }
    }

    public void GetItem(Texture itemText, string ItemContents)
    {
        slot = 1;
        for (int i = 0; i < ItemsInHotbar.Length; i++)
        {
            if (ItemsInHotbar[slot] != "")
            {
                if (ItemsInHotbar[slot] != ItemContents)
                {
                    slot++;
                }
            }
        }
        HotBarSlotItems[slot] += 1;

        

        if (slot == 1)
        {
            HotBarSlot1.texture = itemText;
        } else if (slot == 2)
        {
            HotBarSlot2.texture = itemText;
        } else if (slot == 3)
        {
            HotBarSlot3.texture = itemText;
        } else if (slot == 4)
        {
            HotBarSlot4.texture = itemText;
        }

        ItemsInHotbar[slot] = ItemContents;
    }


    public void RemoveItem(int slotItem)
    {
        if (ItemsInHotbar[slotItem] != "")  HotBarSlotItems[slotItem] -= 1;
        if (HotBarSlotItems[slotItem] == 0)
        {
            if (slotItem == 1)
            {
                HotBarSlot1.texture = Empty;
            } else if (slotItem == 2)
            {
                HotBarSlot2.texture = Empty;
            } else if (slotItem == 3)
            {
                HotBarSlot3.texture = Empty;
            } else if (slotItem == 4)
            {
                HotBarSlot4.texture = Empty;
            }
            ItemsInHotbar[slotItem] = "";
        }
        
    }


    private void ResetAllBoxes()
    {
        HoveringInventoryPanel1.SetActive(false);
        HoveringInventoryPanel2.SetActive(false);
        HoveringInventoryPanel3.SetActive(false);
        HoveringInventoryPanel4.SetActive(false);

    }
}
