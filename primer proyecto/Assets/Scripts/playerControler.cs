using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler: MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 30f;
    private float horizontalInput;
    private float verticalInput;


    void Start()
    {
        
    }
     
   
    private void Update()
    {

        //detectar imputhorizontal
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // movimiento hacia adelante
        // transform.Translate(0, 0, 1); 
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        //movimiento lateral manual
        //transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
