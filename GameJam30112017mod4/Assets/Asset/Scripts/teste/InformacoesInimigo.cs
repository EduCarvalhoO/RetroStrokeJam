using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformacoesInimigo : MonoBehaviour {

	public int restCont1;
	// Use this for initialization
	void Start () {
		//restCont1 = GetComponent<SpawnInimigos> ().contadorDeiniNoCamp01;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision colider)
	{

		if (colider.gameObject.tag == "Atak1")
		{

			//colocar animacao morto
			Destroy(gameObject);
			restCont1 = restCont1 - 1;

		}

	}
}