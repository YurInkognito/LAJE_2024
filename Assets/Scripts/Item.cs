using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
public class Item: MonoBehaviour
{
    public static event Action<string> Vendido;
    public int itemValue;
    public string itemTag;
    public Jogador jogador;

    void OnDestroy()
    {
        Vendido?.Invoke(itemTag);
        
        if (jogador != null)
        {
            jogador.DinheiroTotal += itemValue;
        }
    }
}