using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    public string Name;
    public int Quantity;

    public Resource()
    {
    }

    public Resource(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
}

public class Recurso
{
    public string Name;
    public Dictionary<string, int> RequiredResources;

    public Recurso(string name, Dictionary<string, int> requiredResources)
    {
        Name = name;
        RequiredResources = requiredResources;
    }
}
