using System;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class exercicio08 : MonoBehaviour
{


    /*
     (Contador de horas e dias) Crie um script que em que uma
    variável inteira hora seja incrementada de uma unidade a cada 10
    segundos e volte a ser 0 quando alcançar o valor 24. Quando
    completar um ciclo, incremente uma variável dias e escreva o
    número de dias que se passaram no console. (Coloque o código
    dentro da função-evento Update).
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

