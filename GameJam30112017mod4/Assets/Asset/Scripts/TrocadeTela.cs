using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrocadeTela : MonoBehaviour {


    public GameObject fadeOb;


    public Image fade;

    void Start () {
        StartCoroutine(espera());
    }
	
	void Update () {
		
	}
    IEnumerator espera()
    {

        yield return new WaitForSeconds(6f);
        fadeOb.SetActive(true);
        fade.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Diner");




    }
    void FadeIn()
    {
        fade.CrossFadeAlpha(1.0f, 1.5f, false);
    }
}
