using UnityEngine;

public class exercicio03 : MonoBehaviour
{


    System.Random rand = new System.Random();

    int vidaGanha;

    public int pocaovida = 0;

    public int vida = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (vida <= 0 && pocaovida > 0)
        {
            vidaGanha = rand.Next(50, 100);

            print("Levante, das cinzas");

            print("você voltou dos mortos");

            print("voce tem " + vidaGanha + " HP");

        }
        else
        {
            print("Game over");
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
