using UnityEngine;

public class exercicio04 : MonoBehaviour
{
    /*
     (Verificar item de invent�rio) Um jogador possui itens limitados
    no invent�rio. Verifique se o jogador possui uma "Po��o de Vida".
    Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
    indispon�vel".
     */

    public bool inventario;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(inventario ? "Usando Po��o de vida" : "Po��o indisponivel");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
