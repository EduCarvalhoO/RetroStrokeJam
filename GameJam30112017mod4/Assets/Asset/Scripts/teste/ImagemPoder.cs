using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagemPoder : MonoBehaviour {
    public Sprite poder1;
    public Sprite poder2;
    public Sprite poder3;
    public Sprite semPoder;


    void Start(){

        

    }


	// Update is called once per frame
	void Update () {
		
        if (DadosJogador.tipoDoPoder == 1)
        {
            GetComponent<Image>().sprite = poder1;
        }

        if (DadosJogador.tipoDoPoder == 2)
        {
            GetComponent<Image>().sprite = poder2;
        }

        if (DadosJogador.tipoDoPoder == 3)
        {
            GetComponent<Image>().sprite = poder3;
        }

        if (DadosJogador.tipoDoPoder == 0)
        {
            GetComponent<Image>().sprite = semPoder;
        }


    }
}
