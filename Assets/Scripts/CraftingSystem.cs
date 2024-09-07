using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingSystem : MonoBehaviour
{
    public Inventory playerInventory;

    void Start()
    {
        playerInventory = new Inventory();

        Dictionary<string, int> ringRequirements = new Dictionary<string, int>
        {
            { "Gold", 2 },
            { "Diamond", 1 }
        };

        Item diamondRing = new Item("Diamond Ring", ringRequirements);

    }

}