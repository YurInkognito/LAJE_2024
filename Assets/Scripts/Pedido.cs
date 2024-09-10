using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string item1;
    public string item2;
    public string item3;
    public GameObject pedido1;
    public GameObject pedido2;
    public GameObject pedido3;
    public GameObject CaixaDialogo;
    public Character cliente;
    
    void OnEnable()
    {
        
        Item.Vendido += ConfirmaVenda;
    }

    void OnDisable()
    {       
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
    void Update()
    {
       if (pedido1.activeSelf == false && pedido2.activeSelf == false && pedido3.activeSelf == false)
       {           
            Debug.Log("cabou a venda");
            cliente.compraFim = true;
            CaixaDialogo.SetActive(true);
            Destroy(gameObject);
            Destroy(pedido1);
            Destroy(pedido2);
            Destroy(pedido3);
       }
       else
       {
       }
       
    }
    
}
