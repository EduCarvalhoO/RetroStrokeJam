using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawItens : MonoBehaviour {
	[SerializeField]
	private GameObject []Itens;
	[SerializeField]
	private float conometroIni1 = 9.3f;
	[SerializeField]private float recetimpo1= 0.0f;
	public int contadorDeItemsNoCamp01= 0;
	[SerializeField]private int quantMaxTipo = 2;
	[SerializeField]private int numItem;
	[SerializeField]private int numMax = 4;
	private List<GameObject> activeTiles;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		recetimpo1 += Time.deltaTime;
		SpawIniTipo1 ();
		numItem = Random.Range (0, numMax);
	}
	public void SpawIniTipo1 (){
		if (contadorDeItemsNoCamp01 < quantMaxTipo){
			if (conometroIni1  < recetimpo1 ){
				Instantiate(Itens[numItem], transform.position, transform.rotation);
				recetimpo1 = 0.0f;
				if (contadorDeItemsNoCamp01 >= 0) {
					contadorDeItemsNoCamp01 = contadorDeItemsNoCamp01 + 1;
				} 
				else {
					contadorDeItemsNoCamp01 = 0;
				}
				}
		}

	}

}
