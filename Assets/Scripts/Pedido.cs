using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string item1;
    public string item2;
    public string item3;
    public GameObject pedido1;
    public GameObject pedido2;
    public GameObject pedido3;
    // Start is called before the first frame update
    void OnEnable()
    {
        // Subscribe to the OnObjectDestroyed event
        Item.Vendido += ConfirmaVenda;
    }

    void OnDisable()
    {
        // Unsubscribe from the OnObjectDestroyed event to avoid memory leaks
        Item.Vendido -= ConfirmaVenda;
    }
    void ConfirmaVenda(string itemVendido)
    {
        if (itemVendido == item1)
        {
            if (pedido1 != null)
            {
                pedido1.SetActive(false);
            }
        }
        else if (itemVendido == item2)
        {
            if (pedido2 != null)
            {
                pedido2.SetActive(false);
            }
        }
        else if (itemVendido == item3)
        {
            if (pedido3 != null)
            {
                pedido3.SetActive(false);
            }
        }
       
    }
}
