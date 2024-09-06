using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    public int itemValue;
    internal IEnumerable<object> RequiredResources;
    private string v;
    private Dictionary<string, int> ringRequirements;

    public Item(string v, Dictionary<string, int> ringRequirements)
    {
        this.v = v;
        this.ringRequirements = ringRequirements;
    }

    public Item(string itemName, IEnumerable<object> requiredResources, string v, Dictionary<string, int> ringRequirements)
    {
        this.itemName = itemName;
        RequiredResources = requiredResources;
        this.v = v;
        this.ringRequirements = ringRequirements;
    }
    
    public Item(int itemValue)
    {
       this.itemValue = itemValue;
    }


    void Start()
    {
        if (string.IsNullOrEmpty(itemName))
        {
            itemName = "Item Desconhecido";
        }
    }

    void Update()
    {
        
    }

}
