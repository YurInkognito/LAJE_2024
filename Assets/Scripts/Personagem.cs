using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personagem : MonoBehaviour
{
<<<<<<< HEAD
    public string nome;           
    public int dinheiro;          
    public string dialogo;        
    public List<string> pedidos;  
    public string pedidoAtual;
    public bool itemEntregue = false;
    public GameObject janelaDePedido; 
    public Text dialogoFinal; 
=======
    public string nome;           // Nome do personagem
    public int dinheiro;          // Dinheiro do personagem
    public string dialogo;        // Di�logo do personagem
    public List<string> pedidos;  // Lista de pedidos do personagem
    public string pedidoAtual;
    public bool itemEntregue = false;
    public GameObject janelaDePedido; // Refer�ncia � janela de pedido
    public string dialogoFinal; // Texto do di�logo final
>>>>>>> 227ba8e4373315380d6cc0e720b4a7556c1b6c36
    public bool todosItensEntregues = false;
    private int itensEntregues = 0;

    public void InicializarPersonagem(string nome, int dinheiroInicial)
    {
        this.nome = nome;
        this.dinheiro = dinheiroInicial;
        this.pedidos = new List<string>();
    }

<<<<<<< HEAD
=======
    // Adicionar um pedido � lista de pedidos
>>>>>>> 227ba8e4373315380d6cc0e720b4a7556c1b6c36
    public void AdicionarPedido(string pedido)
    {
        pedidos.Add(pedido);
    }

<<<<<<< HEAD
=======
    // Atualizar o di�logo do personagem
>>>>>>> 227ba8e4373315380d6cc0e720b4a7556c1b6c36
    public void AtualizarDialogo(string novoDialogo)
    {
        dialogo = novoDialogo;
    }

<<<<<<< HEAD
=======
    // Exibir informa��es do personagem
>>>>>>> 227ba8e4373315380d6cc0e720b4a7556c1b6c36
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

<<<<<<< HEAD
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

=======
    // Fun��o para adicionar ou remover dinheiro
    public void AlterarDinheiro(int quantia)
    {
        dinheiro += quantia; // Adiciona ou subtrai dinheiro
    }

    // M�todo para verificar colis�o com o item
>>>>>>> 227ba8e4373315380d6cc0e720b4a7556c1b6c36
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Item item = collision.GetComponent<Item>();

        if (item != null)
<<<<<<< HEAD
=======
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
>>>>>>> 227ba8e4373315380d6cc0e720b4a7556c1b6c36
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

<<<<<<< HEAD
=======
    // M�todo chamado quando todos os itens s�o entregues
>>>>>>> 227ba8e4373315380d6cc0e720b4a7556c1b6c36
    private void ConcluirEntrega()
    {
        Debug.Log("Todos os itens foram entregues!");

        if (janelaDePedido != null)
        {
            Destroy(janelaDePedido);
        }

<<<<<<< HEAD
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
=======
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
>>>>>>> 227ba8e4373315380d6cc0e720b4a7556c1b6c36
    }

}
