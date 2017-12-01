using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAInimigo : MonoBehaviour {

	[SerializeField]private float campo;
	//private Transform player;
	private GameObject Player;
	[SerializeField]private float velocidadeIni;
	 Transform player;
    UnityEngine.AI.NavMeshAgent nav;
	//Animator ani;



	void Start(){
		velocidadeIni = 8f;

		// ani = GetComponent <Animator> ();
	}
	void Update(){
		campo = Vector3.Distance (Player.transform.position, transform.position);
		Verifica ();
		nav.SetDestination (player.position);
	}
	private void Verifica(){
		if (campo > 2 && campo < 60 ) {
			Seguir ();
			Olhar ();
			Debug.Log("Se aproximando");
		}
		if (campo <= 2) {
			Olhar ();
			Atacar ();
			Debug.Log("pronto para ataque");
		}
	}
	private void Olhar(){
		// eixo rotacao
		Quaternion visao;
		visao = Quaternion.LookRotation (transform.position - Player.transform.position);
		// quando ele for rotacionar ele vai deslizar(Slerp)
		transform.rotation = Quaternion.Slerp (transform.rotation,visao,6f * Time.deltaTime);
	}
	private void Seguir(){
		//ani.SetBool ("Correndo");
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
	}
		
	private void Atacar(){
		//ani.SetTrigger ("Atakando");
		//colocar ataque do inimigo

	}


}