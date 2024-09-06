using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Dictionary<string, Resource> Resources { get; private set; }
    public List<Item> CraftedItems { get; private set; }

    public Inventory()
    {
        Resources = new Dictionary<string, Resource>();
        CraftedItems = new List<Item>();
    }

    public void AddResource(string resourceName, int quantity)
    {
        if (Resources.ContainsKey(resourceName))
        {
            Resources[resourceName].Quantity += quantity;
        }
        else
        {
            Resources.Add(resourceName, new Resource(resourceName, quantity));
        }
    }

    // (Vou concertar ainda)
    //public bool hasrequiredresources(item item)
    //{
    //    foreach (var requiredresource in item.requiredresources)
    //    {
    //        if (!resources.containskey(requiredresource.key) || resources[requiredresource.key].quantity < requiredresource.itemvalue)
    //        {
    //            return false;
    //        }
    //    }
    //    return true;
    //}

    //public void craftitem(item item)
    //{
    //    if (hasrequiredresources(item))
    //    {
    //        foreach (var requiredresource in item.requiredresources)
    //        {
    //            resources[requiredresource.key].quantity -= requiredresource.value;
    //        }
    //        crafteditems.add(item);
    //    }
    //    else
    //    {
    //        // handle case where resources are insufficient
    //        debug.log("not enough resources to craft " + item.itemname);
    //    }
    //}

    public void SellItem(Item item, int price)
    {
        if (CraftedItems.Contains(item))
        {
            CraftedItems.Remove(item);
            // Implement your selling logic, e.g., add money to player's balance
            Debug.Log(item.itemName + " sold for " + price + " currency.");
        }
        else
        {
            // Handle case where item isn't in inventory
            Debug.Log("Item " + item.itemName + " is not in the inventory.");
        }
    }
}
