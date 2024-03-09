using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private int spawnRangeX = 9;
    private int spawnPosZ = 35;
    private int spawnPosX;
    private int startTimeOfSpawn = 2;
    private float spawnInterval = 0.75f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startTimeOfSpawn,spawnInterval); 
        InvokeRepeating("SpawnRandomAnimal",10,1);
    }

    // Update is called once per frame
    void Update()
    {
        
            
    }

    void SpawnRandomAnimal()
    {   
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(spawnPosX, 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
    
}
