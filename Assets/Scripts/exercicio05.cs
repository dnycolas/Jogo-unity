using UnityEngine;

public class exercicio05 : MonoBehaviour
{

    /*
     (Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador
    recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
    exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
    incompleta".
     */

    System.Random desempenho = new System.Random();
    public int pontos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pontos = desempenho.Next(0, 200);

        if (pontos >= 50)
        {
            print("parab�ns"); 
        }
        else
            {
            print("ruinzinho hein!");
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
