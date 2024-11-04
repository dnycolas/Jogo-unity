//using System.Collections;
using UnityEngine;

public class Geral1 : MonoBehaviour
{
    public string variavelPublica;

    int vidaJogador = 100;

    //float velocidadeCarro = 125.5f;

    //string nome = "catota";

    char apelido = 'C';

    //bool vivo = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(vidaJogador);
        print(apelido);

        print(variavelPublica);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
