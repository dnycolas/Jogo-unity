using UnityEngine;

public class exercicio09 : MonoBehaviour
{

    /*
     (Placar final) Crie um script que lê o placar de uma partida entre
time A e time B. Depois, escreva no console qual dos três
resultados possíveis aconteceu: vitória do time A, vitória do time B
ou empate. Se o empate teve mais de 3 pontos para cada lado,
escreva que foi “um empate emocionante”.
     */

    public int timeA;
    public int timeB;

    System.Random rand = new System.Random();

    int placar;

    int desempenhoA;

    int desempenhoB;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placar = rand.Next(0, 5);

        desempenhoA = rand.Next(0, 3);

        desempenhoB = rand.Next(0, 3);



        timeA = placar + desempenhoA;
        timeB = placar + desempenhoB;

        print("time A " +  timeA + " X " + "time B " + timeB);

        if (timeA == timeB && timeA > 3 && timeB > 3)
        {
            print("Foi um Otimo empate");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
