using System;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class exercicio08 : MonoBehaviour
{


    /*
     (Contador de horas e dias) Crie um script que em que uma
    vari�vel inteira hora seja incrementada de uma unidade a cada 10
    segundos e volte a ser 0 quando alcan�ar o valor 24. Quando
    completar um ciclo, incremente uma vari�vel dias e escreva o
    n�mero de dias que se passaram no console. (Coloque o c�digo
    dentro da fun��o-evento Update).
     */

    public int dias;
    float segundos;
    public int horas;

    [SerializeField] decimal decimalNumero;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        decimalNumero = Mathf.RoundToInt(segundos += Time.deltaTime);

        print(decimalNumero);



        if (segundos > 10)
        {

            segundos = 0;

            horas++;
        }

        if (horas >= 24)
        {

            dias++;


        }

        if (horas == 24)
        {
            horas = 0;
        }

        
        
    }
}

