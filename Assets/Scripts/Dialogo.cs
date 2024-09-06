using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{
    [TextArea(3, 10)] 
    public string dialogo;  

    public Text caixaDeTexto;  

    void Start()
    {
        if (caixaDeTexto != null)
        {
            caixaDeTexto.gameObject.SetActive(false);
        }
    }

    public void TocarDialogo()
    {
        if (caixaDeTexto != null)
        {
            caixaDeTexto.gameObject.SetActive(true);  
            caixaDeTexto.text = dialogo;  
        }
    }

    public void DefinirDialogo(string novoDialogo)
    {
        dialogo = novoDialogo;
    }

    public void EsconderDialogo()
    {
        if (caixaDeTexto != null)
        {
            caixaDeTexto.gameObject.SetActive(false); 
        }
    }
}
