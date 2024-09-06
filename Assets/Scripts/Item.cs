using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;

    // Start is called before the first frame update
    void Start()
    {
        if (string.IsNullOrEmpty(itemName))
        {
            itemName = "Item Desconhecido";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
