using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName;
    public int dinheiro;
    public string pedido;
    public string dialogo;
    public bool pedidoEntregue;
    public string targetTag;

    private void Start()
    {
        // Exemplo de inicialização das variáveis na Unity
        characterName = "Yuri";
        dinheiro = 100;
        pedido = "Espada Mágica";
        dialogo = "Olá, comerciante! Estou precisando de uma Espada Mágica, você poderia me fazer uma?";
        targetTag = "ItemCraftado"; // Defina a tag do objeto alvo do pedido
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == targetTag)
        {
            // Entregar o item pedido
            Destroy(collision.gameObject);
            // Ações adicionais ao entregar o item
            ConfirmDelivery();
        }
    }

    private void ConfirmDelivery()
    {
        Debug.Log("Item entregue: " + pedido);
        pedidoEntregue = true;
        // Lógica adicional de confirmação, como alterar diálogos, recompensas, etc.
    }
}