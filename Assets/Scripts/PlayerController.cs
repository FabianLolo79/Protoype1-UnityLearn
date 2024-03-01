using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horsePower = 0; // caballos de fuerza
    [SerializeField] private float turnSpeed = 45.0f;
    [SerializeField] GameObject centerOfMass; 
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    private void Start()
    {
        playerRb.centerOfMass = centerOfMass.transform.position;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //ac� tomamos el input del player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // ac� movemos el player (Time.deltatime cambia la frecuencia del update en segundos y no frames o cuadros)
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);

        // ac� giramos el player 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
