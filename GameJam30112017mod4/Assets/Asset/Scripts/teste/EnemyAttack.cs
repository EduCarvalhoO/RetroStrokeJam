using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;


    Animator anim;
    GameObject player;
	DadosJogador dadosjogador;
    //EnemyHealth enemyHealth;
    bool playerInRange;
    float timer;


    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
		dadosjogador = player.GetComponent <DadosJogador> ();
        //enemyHealth = GetComponent<EnemyHealth>();
        anim = GetComponent <Animator> ();
    }


    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = true;
        }
    }


    void OnTriggerExit (Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = false;
        }
    }


    void Update ()
    {
        timer += Time.deltaTime;

       /** 
        * if(timer >= timeBetweenAttacks && playerInRange/* && enemyHealth.currentHealth > 0*/
		//)
		/** {
            Attack ();
        }

		if(dadosjogador.vida <= 0)
        {
           // animacao morto player
        }**/
    }


    void Attack ()
    {
        timer = 0f;

		/** if(dadosjogador.vida  > 0)
        {
			// colocar dano 
        }**/
    }
}
