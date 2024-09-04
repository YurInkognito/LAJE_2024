using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource
{
    public string Name { get; private set; }
    public int Quantity { get; set; }

    public Resource(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
}

public class Item
{
    public string Name { get; private set; }
    public Dictionary<string, int> RequiredResources { get; private set; }

    public Item(string name, Dictionary<string, int> requiredResources)
    {
        Name = name;
        RequiredResources = requiredResources;
    }
}