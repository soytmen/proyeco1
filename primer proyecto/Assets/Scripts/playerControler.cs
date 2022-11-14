using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler: MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 10f;
    private float horizontalInput;



    void Start()
    {
        
    }
     
   
    private void Update()
    {

        //detectar imputhorizontal
        horizontalInput = Input.GetAxis("Horizontal");
        // movimiento hacia adelante
        // transform.Translate(0, 0, 1); 
        transform.Translate(Vector3.forward * 20 * Time.deltaTime);
        //movimiento lateral manual
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
    }
}
