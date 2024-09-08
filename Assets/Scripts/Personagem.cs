using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Character : MonoBehaviour
{
    public string characterName;
    public int dinheiro;
    public List<string> pedido;
    public string dialogo;
    public bool pedidoEntregue;
    public List<string> targetTags;

     private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se a tag do objeto colidido está na lista de tags alvo
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
    private void ConfirmDelivery()
    {
        Debug.Log("Item entregue: " + pedido);
        // Lógica adicional de confirmação, como alterar diálogos, recompensas, etc.
    }
}