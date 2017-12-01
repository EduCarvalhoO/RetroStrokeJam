using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarColete : MonoBehaviour {

	public void OnCollisionEnter(Collision colider){

		if (colider.gameObject.tag == "Player") {

			DadosJogador.colete = DadosJogador.colete + 100;

		}

	}
}
