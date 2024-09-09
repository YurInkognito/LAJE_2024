using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
    public GameObject[] dialogos; // Drag each dialogue text GameObject here
    public int currentTextIndex = 0;    // Index to keep track of current text

    // Método para ser chamado ao clicar no botão de "Skip"
   void OnEnable()
    {
        // Iterate through each object and enable it
        foreach (GameObject obj in dialogos)
        {
            if (obj != null) // Check if the object is assigned
            {
                obj.SetActive(true); // Enable the object
            }
        }
        
        Debug.Log("Objects enabled!");
    }
 public void OnSkipButtonClicked()
    {
        // Check if the current text index is within bounds
        if (currentTextIndex < dialogos.Length)
        {
            // Disable the current text
            dialogos[currentTextIndex].SetActive(false);
            
            // Increment the index to show the next text
            currentTextIndex++;

            // Check if there is a next text to show
            if (currentTextIndex < dialogos.Length)
            {
                // Enable the next text
                dialogos[currentTextIndex].SetActive(true);
            }
            else
            {
                // If no more texts, you can end the dialogue or loop
                Debug.Log("End of dialogue.");
            }
            Debug.Log("Skip button clicked!");
        }
    }
}

