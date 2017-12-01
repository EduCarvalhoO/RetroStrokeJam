using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tempoJogo : MonoBehaviour
{
    public Text contadorText;
    public float segundos;
    public int minutos;
    bool cont = false;

    public GameObject fadeOb;

    public Image fade;

    bool fase = false;



    // Use this for initialization
    void Start()
    {
        if (cont == false)
        {
            iniciarContador();
        }
    }

    public void contarTempo()
    {
        if (segundos > 0.0f)
        {
            segundos -= 0.1f;
            if (minutos > 0)
                contadorText.text = minutos.ToString() + " . " + segundos.ToString("F0");
            else
            {
                contadorText.text = segundos.ToString("F0");
            }

        }
        else
        {
            segundos = 59;
            if (minutos > 0)
            {
                minutos = minutos - 1;
            }
            else
            {
                CancelInvoke();

                cont = false;
                contadorText.text = "00";
                StartCoroutine(espera());

            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void iniciarContador() {
        minutos = 4;
        segundos = 60;
        InvokeRepeating("contarTempo", 0.0f, 0.1f);
        cont = true;
    }
    public void proximaFase() {
        if (cont == false) {
            SceneManager.LoadScene("Discoteca");
        }
    }
    IEnumerator espera()
    {
        fadeOb.SetActive(true);
        fade.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(2);
        if (fase == false)
        {
            SceneManager.LoadScene("Discoteca");
            fase = true;
        }
        else {
           
        }

    }

    void FadeIn()
    {
        fade.CrossFadeAlpha(1.0f, 1.5f, false);
    }
}