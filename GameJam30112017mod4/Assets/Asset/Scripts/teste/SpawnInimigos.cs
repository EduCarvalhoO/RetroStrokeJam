using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInimigos : MonoBehaviour {
	[SerializeField]
	private GameObject Inimigo001;
	[SerializeField]
	private float conometroIni1 = 9.3f;
	[SerializeField]private float recetimpo1= 0.0f;
	public int contadorDeiniNoCamp01= 0;
	[SerializeField]private int quantMaxTipo = 7;
	
	private List<GameObject> activeTiles;
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		recetimpo1 += Time.deltaTime;
		SpawIniTipo1 ();
	}
	public void SpawIniTipo1 (){
		if (contadorDeiniNoCamp01 < quantMaxTipo){
			if (conometroIni1  < recetimpo1 ){
				Instantiate(Inimigo001, transform.position, transform.rotation);
				recetimpo1 = 0.0f;
				contadorDeiniNoCamp01 = contadorDeiniNoCamp01 + 1;
			}
		}

	}
	
}
