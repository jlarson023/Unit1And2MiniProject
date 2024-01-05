using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemy;

    public float xSpawnRange = 12.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        //generate spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), transform.position.y, transform.position.z);

        int enemyIndex = Random.Range(0, enemy.Length);

        Instantiate(enemy[enemyIndex], spawnPos, enemy[enemyIndex].transform.rotation);
    }

}
