using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTiro : MonoBehaviour
{
    public GameObject mira;
    public Transform projetil;
    public Transform bomba;

    public AudioClip somTiro;

    void Start()
    {

    }


    void Update()
    {
        //Implementar movimentação do tiro

        if (Input.GetMouseButtonDown(0))
        {
            
            Instantiate(projetil, mira.transform.position, mira.transform.rotation);
            GetComponent<AudioSource>().PlayOneShot(somTiro);

            //Instantiate(projetil, transform.position, transform.rotation);
        } 

        if (Input.GetMouseButtonDown(1) && DadosJogador.tipoDoPoder == 1)
        {

            Instantiate(bomba, mira.transform.position, mira.transform.rotation);
            DadosJogador.tipoDoPoder = 0;

        }

        if (Input.GetMouseButtonDown(1) && DadosJogador.tipoDoPoder == 2)
        {

            tempoVeloz();
           

        }
    }

    public void tempoVeloz()
    {
            DadosJogador.velocidade = 18;
            DadosJogador.tipoDoPoder = 0;
            StartCoroutine(espera());
    }

    IEnumerator espera()
    {
        yield return new WaitForSeconds(3);
        if (DadosJogador.velocidade > 10)
        {
            DadosJogador.velocidade = 10;
        }

    }

    }
