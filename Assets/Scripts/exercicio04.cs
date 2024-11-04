using UnityEngine;

public class exercicio04 : MonoBehaviour
{
    /*
     (Verificar item de inventário) Um jogador possui itens limitados
    no inventário. Verifique se o jogador possui uma "Poção de Vida".
    Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
    indisponível".
     */

    public bool inventario;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(inventario ? "Usando Poção de vida" : "Poção indisponivel");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
