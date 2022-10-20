using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMulen : MonoBehaviour
{
    public float snowSpawnDelay = 1;
    float nextSpawnTime;
    public GameObject snowPrefabs;
    void Start()
    {
        nextSpawnTime = Time.time + 10;
    }

    // Update is called once per frame

    void Update()
    {
        if (nextSpawnTime < Time.time)
        {
            nextSpawnTime = nextSpawnTime + snowSpawnDelay;
            var spawnPos = new Vector3(Random.Range(-5f, 5f), 8, 0);
            Instantiate(snowPrefabs, spawnPos, transform.rotation);
        }
    }
}
