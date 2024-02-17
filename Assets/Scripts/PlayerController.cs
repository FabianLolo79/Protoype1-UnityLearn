using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move to vehicle forward
        //transform.Translate(0,0,1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
