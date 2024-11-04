using UnityEngine;

public class exercicio01 : MonoBehaviour
{

    public string texto = "Você venceu a batalha!";

    public int pontosVidas = 0;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(texto);

        if (pontosVidas > 0)
        {
            print("Você esta vivo");
        }
        else
        {
            print("Mas, você morreu");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
