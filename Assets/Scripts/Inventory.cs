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

    public bool HasRequiredResources(Item item)
    {
        foreach (var requiredResource in item.RequiredResources)
        {
            if (!Resources.ContainsKey(requiredResource.Key) || Resources[requiredResource.Key].Quantity < requiredResource.Value)
            {
                return false;
            }
        }
        return true;
    }

    public void CraftItem(Item item)
    {
        if (HasRequiredResources(item))
        {
            foreach (var requiredResource in item.RequiredResources)
            {
                Resources[requiredResource.Key].Quantity -= requiredResource.Value;
            }
            CraftedItems.Add(item);
        }
        else
        {
            // Handle case where resources are insufficient
            Debug.Log("Not enough resources to craft " + item.Name);
        }
    }

    public void SellItem(Item item, int price)
    {
        if (CraftedItems.Contains(item))
        {
            CraftedItems.Remove(item);
            // Implement your selling logic, e.g., add money to player's balance
            Debug.Log(item.Name + " sold for " + price + " currency.");
        }
        else
        {
            // Handle case where item isn't in inventory
            Debug.Log("Item " + item.Name + " is not in the inventory.");
        }
    }
}
