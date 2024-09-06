using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personagem : MonoBehaviour
{
    public string nome;           
    public int dinheiro;          
    public string dialogo;        
    public List<string> pedidos;  
    public string pedidoAtual;
    public bool itemEntregue = false;
    public GameObject janelaDePedido; 
    public Text dialogoFinal; 
    public bool todosItensEntregues = false;

    public void InicializarPersonagem(string nome, int dinheiroInicial)
    {
        this.nome = nome;
        this.dinheiro = dinheiroInicial;
        this.pedidos = new List<string>();
    }

    public void AdicionarPedido(string pedido)
    {
        pedidos.Add(pedido);
    }

    public void AtualizarDialogo(string novoDialogo)
    {
        dialogo = novoDialogo;
    }

    public void ExibirInfo()
    {
        Debug.Log("Nome: " + nome);
        Debug.Log("Dinheiro: " + dinheiro);
        Debug.Log("Diálogo: " + dialogo);

        Debug.Log("Pedidos:");
        foreach (var pedido in pedidos)
        {
            Debug.Log("- " + pedido);
        }
    }

    public void AlterarDinheiro(int quantia)
    {
        dinheiro += quantia; 
    }

    private int itensEntregues = 0;

    void Start()
    {
        pedidos = new List<string> { "Anel", "Colar" };

        if (dialogoFinal != null)
        {
            dialogoFinal.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item item = collision.GetComponent<Item>();

        if (item != null)
        {
            if (pedidos.Contains(item.itemName))
            {
                pedidos.Remove(item.itemName);
                itensEntregues++;

                Debug.Log("Item " + item.itemName + " entregue!");

                Destroy(item.gameObject);

                if (itensEntregues == 2) 
                {
                    todosItensEntregues = true;
                    ConcluirEntrega();
                }
            }
            else
            {
                Debug.Log("Este item não faz parte do pedido.");
            }
        }
    }

    private void ConcluirEntrega()
    {
        Debug.Log("Todos os itens foram entregues!");

        if (janelaDePedido != null)
        {
            Destroy(janelaDePedido);
        }

        if (dialogoFinal != null)
        {
            dialogoFinal.gameObject.SetActive(true);
            dialogoFinal.text = "Obrigado por entregar todos os itens!";
        }

        Invoke("Desaparecer", 3f); 
    }

    private void Desaparecer()
    {
        gameObject.SetActive(false);
    }

}
