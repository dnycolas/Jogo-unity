using UnityEngine;

public class exercicio06 : MonoBehaviour
{

    /*
     (Escolha de personagem) O jogador pode escolher entre o
personagem Guerreiro ou Mago. Exiba "Guerreiro escolhido" se o
jogador selecionar Guerreiro e "Mago escolhido" se selecionar
Mago.
     */

    public bool escolha;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(escolha ? "Mago escolhido" : "Guerreiro escolhido");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
