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
    public bool compraFim;
    public bool vaiEmbora;
    public List<string> targetTags;
    public GameObject[] ativar;
    public GameObject proxCliente;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (targetTags.Contains(collision.gameObject.tag))
        {
            Destroy(collision.gameObject);
            Debug.Log("Item entregue!");            
        }
        else
        {
            Debug.Log("Objeto colidido não é o alvo.");
        }
    }
    void Update()
    {
        if (compraFim == true && vaiEmbora == true)
        {
            Destroy(gameObject);
            proxCliente.SetActive(true);
        }
    }
    void OnEnable()
    {
        ativar[0].SetActive(true);         
        Debug.Log("Objects enabled!");
    }
    void OnDisable()
    {
        
        Debug.Log("Objects disabled!");
    }
}