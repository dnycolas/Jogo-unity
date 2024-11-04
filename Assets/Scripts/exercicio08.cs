using System;
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





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        for (int cont = 1; cont <= 24; cont++)
        {
            print(cont);

            if (cont == 24){ 
                print("Ja se passou um dia inteiro");
                }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
