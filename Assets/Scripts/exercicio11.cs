using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class exercicio11 : MonoBehaviour
{

    //  (Diálogos) Implemente um sistema de diálogos onde o jogador
    //  pode interagir com um NPC(personagem não jogável), e o NPC
    //  responde com diferentes frases dependendo do estado do jogo.
    //  Use switch case para definir as respostas baseadas no estado do
    //  jogador.

    string[] frases = { "OI!", "Legal! o meu é X", "Tchau" };


    public int num = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            num++;
            switch (num)
            {

                case 1:
                    if (num == 1)
                    {
                        print(frases[0]);
                    }
                    break;
                case 2:
                    if (num == 2)
                    {
                        print(frases[1]);
                    }
                    break;
                case 3:
                    if (num == 3)
                    {
                        print(frases[2]);
                    }
                    break;

            }
        }
    }
}
