using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    public float moveSpeed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        if (transform.position.z < -21)
        {
            Destroy(gameObject);
        }
    }
}