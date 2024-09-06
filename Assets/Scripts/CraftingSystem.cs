using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingSystem : MonoBehaviour
{
    public Inventory playerInventory;

    void Start()
    {
        playerInventory = new Inventory();

        // Example resources and items
        playerInventory.AddResource("Gold", 10);
        playerInventory.AddResource("Diamond", 5);

        Dictionary<string, int> ringRequirements = new Dictionary<string, int>
        {
            { "Gold", 2 },
            { "Diamond", 1 }
        };

        Item diamondRing = new Item("Diamond Ring", ringRequirements);

        // Crafting an item
        //playerInventory.CraftItem(diamondRing); (Vou concertar ainda)
    }

}