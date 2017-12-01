using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombaScript : MonoBehaviour {

    public static int danoBomba;
    float velocidade;
    Rigidbody rb;
    public Transform areaExplosao;
    private bool colidiu;
    void Start()
    {
        danoBomba = 100;
        velocidade = 80f;
        
        rb = GetComponent<Rigidbody>();
        colidiu = false;
       
    }


    void Update()
    {   
        if(colidiu == false)
        rb.AddForce(transform.forward * velocidade);
    }

    void OnCollisionEnter(Collision colider)
    {
        colidiu = true;
        areaExplosao.gameObject.SetActive(true);
        Destroy(gameObject,2);


    }
}
