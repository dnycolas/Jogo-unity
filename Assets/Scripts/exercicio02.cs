using UnityEngine;

public class exercicio02 : MonoBehaviour
{

    int sorte;

    System.Random rand = new System.Random();

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Você abriu um baú de power-up");

         sorte = rand.Next(0, 100);

        if (sorte > 50) 
        {
            print("você ganhou poção de velocidade, +speed");
        }
        else
        {
            print("não tinha nada");
        }


        print(sorte);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
