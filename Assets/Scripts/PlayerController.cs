using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        //acá tomamos el input del player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        // acá movemos el player (Time.deltatime cambia la frecuencia del update en segundos y no frames o cuadros)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // acá giramos el player 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
