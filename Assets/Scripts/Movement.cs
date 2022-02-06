using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{   
    public float speed = 4f;
    public float turnSpeed = 1000f;

    
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }
}
