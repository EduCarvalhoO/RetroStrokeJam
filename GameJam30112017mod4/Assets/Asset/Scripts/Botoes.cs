using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Botoes : MonoBehaviour {
    public bool credit = false;
    public GameObject telaCredito;
    public GameObject fadeOb;
    public GameObject Tuto;

    public Image fade;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && credit == true)
        {
            credit = false;
            telaCredito.SetActive(false);
        }

    }

    public void startGame() {
        StartCoroutine(espera());
    }
    public void quitGame() {
        Application.Quit();
    }
    public void creditos() {
        credit = true;
        telaCredito.SetActive(true);
    }
    IEnumerator espera()
    {

        Tuto.SetActive(true);
        yield return new WaitForSeconds(8f);
        fadeOb.SetActive(true);
        fade.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Video");




    }
    void FadeIn() {
        fade.CrossFadeAlpha(1.0f, 1.5f, false);
    }
    void FadeOut() {
        fade.CrossFadeAlpha(0f, 2.5f, true);
    }




}
