using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformacoesJogador : MonoBehaviour {

	private float numVida;
	// Use this for initialization
	void Start () {
		numVida = 100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Vida(float levaVida){
		levaVida = numVida;
	}
}
