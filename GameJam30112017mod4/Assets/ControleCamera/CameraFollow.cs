using UnityEngine;
using System.Collections;

namespace CompleteProject
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;           
        public float smoothing = 5f;        // velocidade que vai seguir


        Vector3 offset;                     


        void Start ()
        {
			// Calcula offset
            offset = transform.position - target.position;
        }


        void FixedUpdate ()
        {
            //ciar a posicao da camera com basse no offset.
            Vector3 targetCamPos = target.position + offset;

            
            transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime);

		}
    }
}