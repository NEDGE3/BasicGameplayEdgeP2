using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //float spawnRangeX = 20;
    float spawnPosZ = 20;
    float startDelay = 2;
    float spawnInterval = 2f;
    int sideMinZ = 2;
    int sideMaxZ = 15;
    int spawnPosX = 20;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalPosition", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimalPosition()
    {
        //spawn top
        SpawnRandomAnimal(new Vector3(-Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ), Quaternion.Euler(0, 180, 0));
        //spawn left side
        SpawnRandomAnimal(new Vector3(-spawnPosX - 5, 0, Random.Range(sideMinZ, sideMaxZ)), Quaternion.Euler(0, 90, 0));
        // spawn right side
        SpawnRandomAnimal(new Vector3(-spawnPosX + 5, 0, Random.Range(sideMinZ, sideMaxZ)), Quaternion.Euler(0, -90, 0));
    }
    void SpawnRandomAnimal(Vector3 spawnPos, Quaternion rotation)
    {
        Instantiate(animalPrefabs[Random.Range(0, animalPrefabs.Length)], spawnPos, rotation);
    }

}
