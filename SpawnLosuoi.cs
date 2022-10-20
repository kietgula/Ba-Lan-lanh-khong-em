using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLosuoi : MonoBehaviour
{
    public float snowSpawnDelay = 1;
    float nextSpawnTime;
    public GameObject snowPrefabs;
    void Start()
    {
        nextSpawnTime = Time.time + 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (nextSpawnTime < Time.time)
        {
            nextSpawnTime = nextSpawnTime + snowSpawnDelay;
            var spawnPos = new Vector3(Random.Range(-4.3f, 4.3f), 8, 0);
            Instantiate(snowPrefabs, spawnPos, transform.rotation);
        }
    }
}
