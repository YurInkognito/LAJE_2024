using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome;           // Nome do personagem
    public int dinheiro;          // Dinheiro do personagem
    public string dialogo;        // Diálogo do personagem
    public List<string> pedidos;  // Lista de pedidos do personagem
    public string pedidoAtual;
    public bool itemEntregue = false;
    public GameObject janelaDePedido; // Referência à janela de pedido
    public Text dialogoFinal; // Texto do diálogo final
    public bool todosItensEntregues = false;

    // Inicializa o personagem com nome e dinheiro
    public void InicializarPersonagem(string nome, int dinheiroInicial)
    {
        this.nome = nome;
        this.dinheiro = dinheiroInicial;
        this.pedidos = new List<string>();
    }

    // Adicionar um pedido à lista de pedidos
    public void AdicionarPedido(string pedido)
    {
        pedidos.Add(pedido);
    }

    // Atualizar o diálogo do personagem
    public void AtualizarDialogo(string novoDialogo)
    {
        dialogo = novoDialogo;
    }

    // Exibir informações do personagem
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

    // Função para adicionar ou remover dinheiro
    public void AlterarDinheiro(int quantia)
    {
        dinheiro += quantia; // Adiciona ou subtrai dinheiro
    }

    void Start()
    {
        pedidoAtual = "Anel"; // Exemplo de pedido inicial do personagem
    }

    // Método para verificar colisão com o item
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

                // Destroi o item após ser entregue
                Destroy(item.gameObject);
            }
            else
            {
                Debug.Log("Este não é o item que o personagem pediu.");
            }
        }
    }

    private int itensEntregues = 0;

    void Start()
    {
        // Exemplo de pedidos do personagem
        pedidos = new List<string> { "Anel", "Colar" };

        // Escondendo o diálogo final no início
        if (dialogoFinal != null)
        {
            dialogoFinal.gameObject.SetActive(false);
        }
    }

    // Método para verificar colisão com o item
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item item = collision.GetComponent<Item>();

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
                Debug.Log("Este item não faz parte do pedido.");
            }
        }
    }

    // Método chamado quando todos os itens são entregues
    private void ConcluirEntrega()
    {
        Debug.Log("Todos os itens foram entregues!");

        // Destruir a janela de pedido
        if (janelaDePedido != null)
        {
            Destroy(janelaDePedido);
        }

        // Ativar o diálogo final
        if (dialogoFinal != null)
        {
            dialogoFinal.gameObject.SetActive(true);
            dialogoFinal.text = "Obrigado por entregar todos os itens!";
        }

        // Fazer o personagem desaparecer após um tempo
        Invoke("Desaparecer", 3f); // Espera 3 segundos antes de desaparecer
    }

    // Desativa ou destrói o personagem
    private void Desaparecer()
    {
        // Você pode desativar o personagem em vez de destruir
        gameObject.SetActive(false);
        // Ou você pode destruí-lo completamente
        // Destroy(gameObject);
    }

}
