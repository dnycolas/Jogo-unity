using UnityEngine;

public class exercicio02 : MonoBehaviour
{

    int sorte;

    System.Random rand = new System.Random();

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Voc� abriu um ba� de power-up");

         sorte = rand.Next(0, 100);

        if (sorte > 50) 
        {
            print("voc� ganhou po��o de velocidade, +speed");
        }
        else
        {
            print("n�o tinha nada");
        }


        print(sorte);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
