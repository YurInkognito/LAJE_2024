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
    private int itensEntregues = 0;

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
        Debug.Log("Dialogo: " + dialogo);

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
            // Se o nome do item for igual ao pedido atual
            if (item.itemName == pedidoAtual)
            {
                itemEntregue = true; // Marca que o item foi entregue
                Debug.Log("Item entregue com sucesso!");

                // Destroi o item ap�s ser entregue
                Destroy(item.gameObject);
            }
            else
            {
                Debug.Log("Este n�o � o item que o personagem pediu.");
            }
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
                Debug.Log("Este item n�o faz parte do pedido.");
            }
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
        // Ativar o di�logo final

        // Fazer o personagem desaparecer ap�s um tempo
        Invoke("Desaparecer", 3f); // Espera 3 segundos antes de desaparecer
    }
}
