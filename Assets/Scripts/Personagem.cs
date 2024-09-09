using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public int dinheiro;
    public GameObject pedido1;
    public GameObject pedido2;
    public GameObject pedido3;
    public bool pedidoEntregue;
    public List<string> targetTags;
    public GameObject[] ativar;
     private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (string tag in targetTags)
        {
            if (collision.gameObject.CompareTag(tag))
            {
                ConfirmarPedido(tag);
                break; 
            }
        }
        if (targetTags.Contains(collision.gameObject.tag))
        {
            Destroy(collision.gameObject);
            Debug.Log("Item entregue!");
            ConfirmDelivery();
        }
        else
        {
            Debug.Log("Objeto colidido não é o alvo.");
        }
    }
    private void ConfirmarPedido(string tag)
    {

    }
    private void ConfirmDelivery()
    {
        
        // Lógica adicional de confirmação, como alterar diálogos, recompensas, etc.
    }
    void OnEnable()
    {
        // Iterate through each object and enable it
        foreach (GameObject obj in ativar)
        {
            if (obj != null) // Check if the object is assigned
            {
                obj.SetActive(true); // Enable the object
            }
        }
        
        Debug.Log("Objects enabled!");
    }

    // Optional: Disabling objects when this script is disabled
    void OnDisable()
    {
        foreach (GameObject obj in ativar)
        {
            if (obj != null) // Check if the object is assigned
            {
                obj.SetActive(false); // Disable the object
            }
        }
        
        Debug.Log("Objects disabled!");
    }
}