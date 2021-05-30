using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle forward
        //transform.Translate(0, 0, 1); //move possition on z direction
        //transform.Translate(Vector3.forward); //move possition on z direction
        transform.Translate(Vector3.forward * Time.deltaTime * 20); //move possition on z direction with 20 meters per second
    }
}
