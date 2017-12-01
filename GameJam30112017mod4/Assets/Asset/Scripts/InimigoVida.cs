using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoVida : MonoBehaviour {

    private int vida;
	Animator anim;


	void Start () {
        vida = 100;	
		anim = GetComponent<Animator> ();
	}
	void Update () {
		if(vida <= 0) {
			anim.SetTrigger ("Moreu");
            Destroy(gameObject, 2f);
        }
	}

	public void OnCollisionEnter(Collision colider){
		if (colider.gameObject.tag == "tiro") {
			vida = vida - Tiro.danoTiro;
		}
        if (colider.gameObject.tag == "bomba")
        {
            vida = vida - bombaScript.danoBomba;
        }
	}
    
}
