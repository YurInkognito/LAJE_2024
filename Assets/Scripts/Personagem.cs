using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Character : MonoBehaviour
{
    public string characterName;
    public int money;
    public string order;
    public string dialogue;
    public bool orderDelivered;

    private void Start()
    {
        // Exemplo de inicialização das variáveis na Unity
        characterName = "João";
        money = 100;
        order = "Espada Mágica";
        dialogue = "Olá, comerciante! Estou precisando de uma Espada Mágica, você pode me fornecer uma?";

        orderDelivered = false;
    }
}