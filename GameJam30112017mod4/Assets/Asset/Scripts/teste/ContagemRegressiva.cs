using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContagemRegressiva : MonoBehaviour {
    public Text contadorText;

    public float segundos;
    public int minutos;
	// Use this for initialization
	void Start () {
        minutos = 9;
        segundos = 60;
        InvokeRepeating("contarTempo", 0.0f, 0.1f);
	}

    void contarTempo()
    {
        if (segundos > 0.0f)
        {
            segundos -= 0.1f;
            if(minutos > 0)
            contadorText.text =minutos.ToString() + " : "+ segundos.ToString("F0");
            else
            {
                contadorText.text = segundos.ToString("F0");
            }

        }else
        {
            segundos = 59;
            if (minutos > 0)
            {
                minutos = minutos - 1;
            }
            else
            {
                CancelInvoke();
                contadorText.text = "acabou o tempo";
            }

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
