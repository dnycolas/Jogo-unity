using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using static UnityEditor.PlayerSettings;
using static UnityEngine.EventSystems.EventTrigger;

public class exercicio07 : MonoBehaviour
{

   /* (Dado com N faces) Para fazer um jogo de RPG, vamos precisar
    calcular probabilidades e simular a rolagem de dados.Crie um
    script em que o usu�rio defina o n�mero de faces de um dado
    (int) e calcule a rolagem de um dado com esse n�mero de faces.
    Use a fun��o abaixo para o c�lculo: Random.Range (valor_min,
    valor_max); (Coloque o c�digo dentro da fun��o-evento Start).
   */

    System.Random numLados = new System.Random();
    int numeroDados;

    int danoJogador;


    System.Random For�a = new System.Random();
    int multiplicadorForca;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numeroDados = numLados.Next(1,6);

        print("O numero do dado foi " +  numeroDados);

        multiplicadorForca = numLados.Next(0, 10);

        print(multiplicadorForca);

        danoJogador = numeroDados * multiplicadorForca;

        if ( danoJogador >= 0 ) 
        {
            print("voc� atacou " +  danoJogador);
        }
        else if ( danoJogador >= 30 && danoJogador <= 59 ) 
        {
            print("voc� atacou " + danoJogador + " foi um bom golpe");
        }
        else
        {
            print("voc� atacou, foi um golpe perfeito");
        }
           

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
