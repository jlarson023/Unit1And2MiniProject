using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float verticalInput;
    public float horizontalInput;
    public float moveSpeed;
    public float rotationSpeed;

    
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
    }
}
