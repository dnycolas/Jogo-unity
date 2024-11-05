using UnityEngine;

public class exercicio05 : MonoBehaviour
{

    /*
     (Pontuação de missão) Após completar uma missão, o jogador
    recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
    exiba "Missão bem-sucedida"; caso contrário, "Missão
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
            print("parabéns"); 
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
