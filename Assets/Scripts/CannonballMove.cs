using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballMove : MonoBehaviour
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
        StartCoroutine(DestroyAfterSeconds(2.0f));
    }

    IEnumerator DestroyAfterSeconds(float numSeconds)
    {
        yield return new WaitForSeconds(numSeconds);
        Destroy(gameObject);
    }

}
