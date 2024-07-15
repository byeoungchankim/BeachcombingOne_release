using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideSpawner : MonoBehaviour
{
    public GameObject fishPrefab;
    public float spawnInterval = 2f;
    public float spawnProbability = 0.1f;

    private void Start()
    {
        InvokeRepeating("SpawnFish", 0f, spawnInterval);
    }

    void SpawnFish()
    {
        if (Random.value < spawnProbability)
        {
            Instantiate(fishPrefab, transform.position, Quaternion.identity);
        }
    }
}