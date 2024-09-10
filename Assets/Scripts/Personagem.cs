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
    public GameObject porta;
    public float spawnTime = 1f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (targetTags.Contains(collision.gameObject.tag))
        {
            Destroy(collision.gameObject);
            Debug.Log("Item entregue!");            
        }
        else
        {

        }
    }
    void Update()
    {
        if (compraFim == true && vaiEmbora == true)
        {
            porta.SetActive(true);
            Invoke ("Spawn", spawnTime);
        }
    }
    void Spawn()
    {
        Destroy(gameObject);
        proxCliente.SetActive(true);
    }
    void OnEnable()
    {
        porta.SetActive(false);
        ativar[0].SetActive(true);         
        Debug.Log("Objects enabled!");
    }
}