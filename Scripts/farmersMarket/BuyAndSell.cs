using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyAndSell : MonoBehaviour
{
    

    public InventoeyManager InventoryManager;
    public Texture TomatoSeeds, CarrotSeeds, PumpkinSeeds, EggplantSeeds, OnionSeeds, PototaSeeds;
    public PlayerMove PM;
    public float Sens;
    private int slot;
    public GameObject Buy, Sell, Points;
    public PointTrading PT;

// Buying


    public void BuyCarrot()
    {
        if (PM.money  >= 2)
        {
            PM.money = PM.money - 2;
            InventoryManager.GetItem(CarrotSeeds, "Carrot Seeds");
        }
    }

    public void BuyTomato()
    {
        if (PM.money >= 4)
        {
            PM.money = PM.money - 4;
            InventoryManager.GetItem(TomatoSeeds, "Tomato Seeds");
        }
    }

    public void BuyPumpkin()
    {
        if (PM.money >= 16)
        {
            PM.money = PM.money - 16;
            InventoryManager.GetItem(PumpkinSeeds, "Pumpkin Seeds");
        }
    }

    public void BuyEggplant()
    {
        if (PM.money >= 32)
        {
            PM.money = PM.money - 32;
            InventoryManager.GetItem(EggplantSeeds, "Eggplant Seeds");
        }
    }


    public void BuyOnion()
    {
        if (PM.money >= 80)
        {
            PM.money = PM.money - 80;
            InventoryManager.GetItem(OnionSeeds, "Onion Seeds");
        }
    }

    public void BuyPotota()
    {
        if (PM.money >= 130)
        {
            PM.money = PM.money - 130;
            InventoryManager.GetItem(PototaSeeds, "Potota Seeds");
        }
    }

    // Selling

    public void SellCarrot()
    {
        slot = 1;
        for (int i = 0; i < InventoryManager.ItemsInHotbar.Length; i++)
        {
            if (InventoryManager.ItemsInHotbar[slot] != "Carrot")
            {
                slot++;
            }
        }

        InventoryManager.RemoveItem(slot);
        PM.money = PM.money + 4;
    }


    public void SellTomato()
    {
        slot = 1;
        for (int i = 0; i < InventoryManager.ItemsInHotbar.Length; i++)
        {
            if (InventoryManager.ItemsInHotbar[slot] != "Tomato")
            {
                slot++;
            }
        }

        InventoryManager.RemoveItem(slot);
        PM.money = PM.money + 8;
    }



    public void SellPumpkin()
    {
        slot = 1;
        for (int i = 0; i < InventoryManager.ItemsInHotbar.Length; i++)
        {
            if (InventoryManager.ItemsInHotbar[slot] != "Pumpkin")
            {
                slot++;
            }
        }

        InventoryManager.RemoveItem(slot);
        PM.money = PM.money + 20;
    }

    public void SellEggplant()
    {
        slot = 1;
        for (int i = 0; i < InventoryManager.ItemsInHotbar.Length; i++)
        {
            if (InventoryManager.ItemsInHotbar[slot] != "Eggplant")
            {
                slot++;
            }
        }

        InventoryManager.RemoveItem(slot);
        PM.money = PM.money + 40;
    }




    public void SellOnion()
    {
        slot = 1;
        for (int i = 0; i < InventoryManager.ItemsInHotbar.Length; i++)
        {
            if (InventoryManager.ItemsInHotbar[slot] != "Onion")
            {
                slot++;
            }
        }

        InventoryManager.RemoveItem(slot);
        PM.money = PM.money + 90;
    }


    public void SellPotota()
    {
        slot = 1;
        for (int i = 0; i < InventoryManager.ItemsInHotbar.Length; i++)
        {
            if (InventoryManager.ItemsInHotbar[slot] != "Potota")
            {
                slot++;
            }
        }

        InventoryManager.RemoveItem(slot);
        PM.money = PM.money + 150;
    }




    // Exit



    public void Exit()
    {
        Buy.SetActive(false);
        Sell.SetActive(false);
        Points.SetActive(false);

        GameObject.Find("Player").GetComponent<PlayerMove>().Sensitivity = Sens;
        Cursor.lockState = CursorLockMode.Locked;
    }






    // Points

    public void PointCarrot()
    {
        slot = 1;
        for (int i = 0; i < InventoryManager.ItemsInHotbar.Length; i++)
        {
            if (InventoryManager.ItemsInHotbar[slot] != "Carrot")
            {
                slot++;
            }
        }

        InventoryManager.RemoveItem(slot);
        PT.Points = PT.Points + 1;
    }


    public void PointTomato()
    {
        slot = 1;
        for (int i = 0; i < InventoryManager.ItemsInHotbar.Length; i++)
        {
            if (InventoryManager.ItemsInHotbar[slot] != "Tomato")
            {
                slot++;
            }
        }

        InventoryManager.RemoveItem(slot);
        PT.Points = PT.Points + 5;
    }



    public void PointPumpkin()
    {
        slot = 1;
        for (int i = 0; i < InventoryManager.ItemsInHotbar.Length; i++)
        {
            if (InventoryManager.ItemsInHotbar[slot] != "Pumpkin")
            {
                slot++;
            }
        }

        InventoryManager.RemoveItem(slot);
        PT.Points = PT.Points + 10;
    }

    public void PointEggplant()
    {
        slot = 1;
        for (int i = 0; i < InventoryManager.ItemsInHotbar.Length; i++)
        {
            if (InventoryManager.ItemsInHotbar[slot] != "Eggplant")
            {
                slot++;
            }
        }

        InventoryManager.RemoveItem(slot);
        PT.Points = PT.Points + 20;
    }




    public void PointOnion()
    {
        slot = 1;
        for (int i = 0; i < InventoryManager.ItemsInHotbar.Length; i++)
        {
            if (InventoryManager.ItemsInHotbar[slot] != "Onion")
            {
                slot++;
            }
        }

        InventoryManager.RemoveItem(slot);
        PT.Points = PT.Points + 40;
    }


    public void PointPotota()
    {
        slot = 1;
        for (int i = 0; i < InventoryManager.ItemsInHotbar.Length; i++)
        {
            if (InventoryManager.ItemsInHotbar[slot] != "Potota")
            {
                slot++;
            }
        }

        InventoryManager.RemoveItem(slot);
        PT.Points = PT.Points + 50;
    }
}
