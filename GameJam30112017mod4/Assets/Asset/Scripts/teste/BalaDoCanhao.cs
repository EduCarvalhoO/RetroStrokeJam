using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaDoCanhao : MonoBehaviour {
    float velocidade;
	// Use this for initialization
	void Start () {
        velocidade = 20f;
        Destroy(gameObject, 2);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, velocidade * Time.deltaTime);
	}
}
