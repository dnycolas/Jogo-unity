using UnityEngine;

public class exercicio10 : MonoBehaviour
{
    /*
     (Itens do invent�rio) Crie um script onde o jogador pode coletar
    diferentes tipos de itens (como moedas, po��es, ou power-ups)
    que t�m efeitos diferentes dependendo do tipo coletado. Use um
    switch case para determinar o efeito de cada tipo de item.
     */

    string[] item = { "moeda", "po��o", "power" };
    [SerializeField] int opcao;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (opcao)
        {

            case 1:
                opcao = 1;

                print(item[0]);

                break;
            case 2:
                opcao = 2;

                print(item[1]);
                break;
            case 3:
                opcao = 3;
                print(item[2]);
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
