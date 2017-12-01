using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movi : MonoBehaviour
{
    //Animação
    Animator animator;
    //Pulo
    public Vector3 direcaoDoPulo = new Vector3(0, 1, 0);
    [Range(1, 20)]
    public float forcaDoPulo = 5.0f;
    [Range(0.5f, 10.0f)]
    public float DistanciaDoChao = 1;
    [Range(0.5f, 5.0f)]
    public float TempoPorPulo = 1.5f;
    public LayerMask LayersNaoIgnoradas = -1;
    private bool estaNoChao, contar = false;
    private float cronometro = 0;
    private Rigidbody corpoRigido;
    

	public SpawItens spawitens;

    


    void Start()
    {
        animator = GetComponent<Animator>();
        corpoRigido = GetComponent<Rigidbody>();
        
    }


    void Update()
    {

        
        


        //Movimento padrão
        if (Input.GetKey(KeyCode.D))
        {
           
            animator.SetInteger("Corre", 1);
            transform.Rotate(0, 3, 0);
          
        }
        if (Input.GetKey(KeyCode.A))
        {
           
            animator.SetInteger("Corre", 1);
            transform.Rotate(0, -3, 0);
            
        }
        if (Input.GetKey(KeyCode.W))
        {
        
            animator.SetInteger("Corre", 1);
            transform.Translate(0, 0, DadosJogador.velocidade * Time.deltaTime);
            
        }
        else
        {
            animator.SetInteger("Corre", 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            
            animator.SetInteger("Corre", 1);
            transform.Translate(0, 0, -DadosJogador.velocidade * Time.deltaTime);
        }

       
        //Pulo
        estaNoChao = Physics.Linecast(transform.position, transform.position - Vector3.up * DistanciaDoChao, LayersNaoIgnoradas);

        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao == true && contar == false)
        {
            corpoRigido.AddForce(direcaoDoPulo * forcaDoPulo, ForceMode.Impulse);
            estaNoChao = false;
            contar = true;
        }

        if (contar == true)
        {
            cronometro += Time.deltaTime;
        }
        if (cronometro >= TempoPorPulo)
        {
            contar = false;
            cronometro = 0;
        }

    }// FIm do Update
	void OnCollisionEnter(Collision colider){

		if (colider.gameObject.tag == "Itens") {
			Destroy(colider.gameObject);
			Debug.Log ("colidiu");
			spawitens.contadorDeItemsNoCamp01 = spawitens.contadorDeItemsNoCamp01 - 1;
		}
	}
    
}// Fim da classe

