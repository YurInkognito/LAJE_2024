using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    public string Name;
    public int Quantity;

    public Resource(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
}

