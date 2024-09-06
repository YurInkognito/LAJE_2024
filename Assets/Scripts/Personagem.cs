using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome;           // Nome do personagem
    public int dinheiro;          // Dinheiro do personagem
    public string dialogo;        // Di�logo do personagem
    public List<string> pedidos;  // Lista de pedidos do personagem
    public string pedidoAtual;
    public bool itemEntregue = false;
    public GameObject janelaDePedido; // Refer�ncia � janela de pedido
    public string dialogoFinal; // Texto do di�logo final
    public bool todosItensEntregues = false;
    private int itensEntregues = 0;

    // Inicializa o personagem com nome e dinheiro
    public void InicializarPersonagem(string nome, int dinheiroInicial)
    {
        this.nome = nome;
        this.dinheiro = dinheiroInicial;
        this.pedidos = new List<string>();
    }

    // Adicionar um pedido � lista de pedidos
    public void AdicionarPedido(string pedido)
    {
        pedidos.Add(pedido);
    }

    // Atualizar o di�logo do personagem
    public void AtualizarDialogo(string novoDialogo)
    {
        dialogo = novoDialogo;
    }

    // Exibir informa��es do personagem
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

    // Fun��o para adicionar ou remover dinheiro
    public void AlterarDinheiro(int quantia)
    {
        dinheiro += quantia; // Adiciona ou subtrai dinheiro
    }

    // M�todo para verificar colis�o com o item
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
            // Se o nome do item for igual a algum pedido
            if (pedidos.Contains(item.itemName))
            {
                // Remove o item da lista de pedidos
                pedidos.Remove(item.itemName);
                itensEntregues++;

                Debug.Log("Item " + item.itemName + " entregue!");

                // Destroi o item
                Destroy(item.gameObject);

                // Verifica se todos os itens foram entregues
                if (itensEntregues == 2) // Exemplo: 2 pedidos no total
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

    // M�todo chamado quando todos os itens s�o entregues
    private void ConcluirEntrega()
    {
        Debug.Log("Todos os itens foram entregues!");

        // Destruir a janela de pedido
        if (janelaDePedido != null)
        {
            Destroy(janelaDePedido);
        }

        // Ativar o di�logo final

        // Fazer o personagem desaparecer ap�s um tempo
        Invoke("Desaparecer", 3f); // Espera 3 segundos antes de desaparecer
    }

    // Desativa ou destr�i o personagem
    private void Desaparecer()
    {
        // Voc� pode desativar o personagem em vez de destruir
        gameObject.SetActive(false);
        // Ou voc� pode destru�-lo completamente
        // Destroy(gameObject);
    }

}
