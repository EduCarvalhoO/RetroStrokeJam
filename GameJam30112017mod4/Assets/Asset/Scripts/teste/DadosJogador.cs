using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DadosJogador : MonoBehaviour {
    public static float vida;
	public static float colete;
    public static int tipoDoPoder;
    public static int qtdMunicao;
    public static int especialBar;
    public static int kill;
    public static int death;
    public static bool estaVivo;
    public static float velocidade;
    public static float tempoVeloz;
   


    private float vidaMaxima;

	private float coleteMaximo;
    
    // imagens
    public Image barraVida;
	public Image barraColete;

    //Textos
    public Text municaoAtual;
    public Text deathText;
    public Text killText;

	// Use this for initialization
	void Start () {
        vidaMaxima = 100;
		coleteMaximo = 100;
		colete = 1;
        vida = vidaMaxima;
        tipoDoPoder = 0;
        kill = 0;
        death = 0;
        estaVivo = true;
        velocidade = 10;
        tempoVeloz = 0;
        

	}
	
	// Update is called once per frame
	void Update () {
        // Texto para indicar o poder atual do personagem
        municaoAtual.text = "Tipo de poder: " + tipoDoPoder;
        deathText.text = "Mortes: " + death;
        killText.text = "Abates: " + kill;
        

        if (estaVivo)
        {
            if (vida <= 0)
            {
                death = death + 1;
                estaVivo = false;
            }
        }
        // Tratamento de vida
        if (vida >= vidaMaxima)
        {
            vida = vidaMaxima;
        }
        if (vida <= 0)
        {
            vida = 0;
           
        }
		if (colete >= coleteMaximo) {
			colete = coleteMaximo;
		}

		if (colete < 0) {
			colete = 0;
		}
        //Código para diminuir a vida
        barraVida.rectTransform.sizeDelta = new Vector2(vida / vidaMaxima * 300, 15);
		barraColete.rectTransform.sizeDelta = new Vector2(colete / coleteMaximo * 300, 15);
        // Fim do tratamento de Vida
              

    }

    
  
	
}
