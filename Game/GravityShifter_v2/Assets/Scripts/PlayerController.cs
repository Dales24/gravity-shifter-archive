using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Public variables to adjust values as needed
    public float xSpeed = 1.0f;
    public float ySpeed = 1.0f;
    public float jumpPower = 1.0f;
    public float gravLevel = 9.8f;

    //Private vars
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Get access to Rigidbody
    }

    // Update is called once per frame
    void Update()
    {
        //Get Input
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        //Apply adjustable variables and deltatime
        float xForce = xInput * xSpeed * Time.deltaTime;
        float yForce = yInput * ySpeed * Time.deltaTime;

        //Move player based on input
        transform.Translate(new Vector3(xForce, 0, yForce));

        //Jump on space
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Use the Vector3.up but convert from a local to global vector
            rb.AddForce(transform.TransformVector(Vector3.up * jumpPower), ForceMode.Impulse);
        }

        //Rotate gravity and view
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            Physics.gravity = transform.TransformVector(Vector3.right * gravLevel);
            transform.Rotate(new Vector3(0, 0, 1), 90, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Physics.gravity = transform.TransformVector(Vector3.left * gravLevel);
            transform.Rotate(new Vector3(0, 0, 1), -90, Space.Self);
        }

    }
}
