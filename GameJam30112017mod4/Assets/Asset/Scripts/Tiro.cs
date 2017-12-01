using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour {
    public static int danoTiro;
    float velocidade;
	Rigidbody rb;

    void Start()
    {
        danoTiro = 20;
        velocidade = 600f;
        Destroy(gameObject, 2);
		rb = GetComponent<Rigidbody> ();
    }


    void Update()
    {
		rb.AddForce (transform.forward * velocidade);	
    }

   void OnCollisionEnter(Collision colider)
    {
        
			Destroy (gameObject);

        
    }

}
