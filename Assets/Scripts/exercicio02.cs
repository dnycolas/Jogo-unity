using UnityEngine;

public class exercicio02 : MonoBehaviour
{

    int vidaPerdida;

    System.Random rand = new System.Random();

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Voc� abriu um ba� de power-up");

       vidaPerdida = rand.Next(1, 6);

        if (vidaPerdida > 3) 
        {
            print("voc� ganhou por�o de velocidade, +speed");
        }
        else
        {
            print("n�o tinha nada");
        }


        print(vidaPerdida);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
