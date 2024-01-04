using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballController : MonoBehaviour
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
    //Destroy cannonball and enemy on collision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

}
