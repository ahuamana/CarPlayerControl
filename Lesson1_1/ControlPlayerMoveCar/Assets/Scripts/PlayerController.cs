using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move the vehicle forward
        //transform.Translate(0, 0, 1); //move possition on z direction
        //transform.Translate(Vector3.forward); //move possition on z direction
        //transform.Translate(Vector3.forward * Time.deltaTime * 20); //move possition on z direction with 20 meters per second
        //transform.Translate(Vector3.right* Time.deltaTime * turnSpeed * horizontalInput);


        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
