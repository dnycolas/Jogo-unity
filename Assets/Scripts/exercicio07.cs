using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using static UnityEditor.PlayerSettings;
using static UnityEngine.EventSystems.EventTrigger;

public class exercicio07 : MonoBehaviour
{

   /* (Dado com N faces) Para fazer um jogo de RPG, vamos precisar
    calcular probabilidades e simular a rolagem de dados.Crie um
    script em que o usuário defina o número de faces de um dado
    (int) e calcule a rolagem de um dado com esse número de faces.
    Use a função abaixo para o cálculo: Random.Range (valor_min,
    valor_max); (Coloque o código dentro da função-evento Start).
   */

    System.Random numLados = new System.Random();
    int numeroDados;

    int danoJogador;


    System.Random Força = new System.Random();
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
            print("você atacou " +  danoJogador);
        }
        else if ( danoJogador >= 30 && danoJogador <= 59 ) 
        {
            print("você atacou " + danoJogador + " foi um bom golpe");
        }
        else
        {
            print("você atacou, foi um golpe perfeito");
        }
           

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
