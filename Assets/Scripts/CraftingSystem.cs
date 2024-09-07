using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingSystem : MonoBehaviour
{
    public int resourceAQuantity = 0;
    public int resourceBQuantity = 0;

    public int craftedItemQuantity = 0;

    public void CraftItem()
    {
        if (resourceAQuantity >= 2 && resourceBQuantity >= 1)
        {
            resourceAQuantity -= 2;
            resourceBQuantity -= 1;
            craftedItemQuantity++;

            Debug.Log("Item crafted successfully!");
        }
        else
        {
            Debug.Log("Not enough resources to craft the item.");
        }
    }

    public void AddResourceA(int amount)
    {
        resourceAQuantity += amount;
    }

    public void AddResourceB(int amount)
    {
        resourceBQuantity += amount;
    }

    public void ResetCraftingSystem()
    {
        resourceAQuantity = 0;
        resourceBQuantity = 0;
        craftedItemQuantity = 0;
    }
}