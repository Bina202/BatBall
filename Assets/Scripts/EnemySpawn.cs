using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject PowerUp;
    private float minTime = 1f;
    private float maxTime = 3.5f;
    private float timeSpawn;
    private float puTime;
    void Start()
    {
        timeSpawn = 0;
        puTime = 15;
    }

    // Update is called once per frame
    void Update()
    {
        timeSpawn -= Time.deltaTime;
        if (timeSpawn <= 0)
        {
            Instantiate(Enemy, transform.position, Quaternion.identity);
            SpawnTime();
        }
        puTime -= Time.deltaTime;
        if (puTime <= 0) 
        {
            Instantiate(PowerUp, transform.position, Quaternion.identity);
            SpawnPu();
        }
    }
    void SpawnTime()
    {
        timeSpawn = Random.Range(minTime, maxTime);
    }
    void SpawnPu()
    {
        puTime = Random.Range(15, 20);
    }
}
