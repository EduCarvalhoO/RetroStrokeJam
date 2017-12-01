using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlaInimigo : MonoBehaviour {

    public GameObject Inimigo;
    public float veloInimigo;
    public bool inimigoAtk;
    public Transform Alvo;
    Animator animator;

    void Start () {
        animator = GetComponent<Animator>();
    }
	

	void Update () {
        Inimigo.transform.Translate(Vector3.back * veloInimigo);

        if (inimigoAtk == true) {
           Inimigo.transform.LookAt(Alvo);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AreaAtencao")
        {
            inimigoAtk = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "AreaAtencao")
        {
            inimigoAtk = false;
        }
    }
}
