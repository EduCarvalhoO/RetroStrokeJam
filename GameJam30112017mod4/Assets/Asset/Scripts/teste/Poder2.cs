using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poder2 : MonoBehaviour {
   
    public void OnCollisionEnter(Collision colider)
    {

        if (colider.gameObject.tag == "Player")
        {
            DadosJogador.tipoDoPoder = 2;
           
        }

    }
}
