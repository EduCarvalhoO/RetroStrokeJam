using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tela : MonoBehaviour
{

    float a, b, telaWidth, telaHeight;


    void Start()
    {
        a = transform.localScale.x;
        b = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {

        telaWidth = Screen.width;
        telaHeight = Screen.height;

        transform.localScale = new Vector3((a * telaWidth / telaHeight), transform.localScale.y, transform.localScale.z);
    }
}