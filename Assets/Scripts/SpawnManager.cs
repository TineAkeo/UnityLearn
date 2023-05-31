using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int xSpawnRange = 10;
    public int zSpawnPos = 10;
    public Vector3 spawnPos = new Vector3(0, 0, 20);

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    public void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    void Update()
    {
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, zSpawnPos);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
