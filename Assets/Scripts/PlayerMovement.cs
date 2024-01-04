using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    public float moveSpeed;
    public float rotationSpeed;
    private float xRange = 21.0f;
    private float zRange = 19.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * -verticalInput * moveSpeed * Time.deltaTime);

        horizontalInput = Input.GetAxis("Horizontal");
        //if the player is moving forward or backward
        if (verticalInput > 0 || verticalInput < 0)
        {
            transform.Rotate(Vector3.forward, horizontalInput * rotationSpeed * Time.deltaTime);
        }

        if(transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    }
}
