using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCamera : MonoBehaviour {

	public Transform alvo;

	public Vector3 offset;
    RaycastHit hit = new RaycastHit();
	public float smoothing = 5f;        // The speed with which the camera will be following.




	void Start ()
	{
		// Calcula offset
		offset = transform.position - alvo.position;
	}

	void LateUpdate(){

	

	}


    void Update()
    {

        transform.position = alvo.position - offset;

        if (Physics.Linecast (alvo.position, transform.position, out hit))
        {
			 transform.position = hit.point + transform.forward * 0.02f;
        }

    }
}
