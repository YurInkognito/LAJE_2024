using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Dialogo : MonoBehaviour
{
    public GameObject[] dialogos; 
    public int currentTextIndex = 0;    
    public List<int> dialogoFim;
    public int clienteSai;    
    public GameObject CaixaDialogo;
    public Character Cliente;
    public int aparecePedido;

    void OnEnable()
    {
        dialogos[currentTextIndex].SetActive(true);
        Debug.Log("Objects enabled!");
    }


    void OnMouseDown()
    {
        Debug.Log("Skip button clicked!");
        if (currentTextIndex == aparecePedido)
        {
        Cliente.ativar[1].SetActive(true);
        }
            if (clienteSai == currentTextIndex)
            {
                Debug.Log("Fuiii");
                Cliente.vaiEmbora = true;
            }
                if (dialogoFim.Contains(currentTextIndex))
                {
                    CaixaDialogo.SetActive(false);
                    dialogos[currentTextIndex].SetActive(false);
                    currentTextIndex++;

                    Debug.Log("deletowww");
                }
                else if (currentTextIndex < dialogos.Length)
                {
                    dialogos[currentTextIndex].SetActive(false);            
                    currentTextIndex++;

                    if (currentTextIndex < dialogos.Length)
                    {
                        dialogos[currentTextIndex].SetActive(true);
                    }
                    else
                    {
                        Debug.Log("End of dialogue.");
                    }
                 Debug.Log("Skip button clicked!");
        }
            
    }
}

