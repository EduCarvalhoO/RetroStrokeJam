using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poder1 : MonoBehaviour {

	public void OnCollisionEnter(Collision colider)
    {

        if (colider.gameObject.tag == "Player")
        {
            DadosJogador.tipoDoPoder = 1;
        }

    }
}
