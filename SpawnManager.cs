using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefab;
    private float spawnPosX = 23;
    private float spawnPosZ = 31;

    private int startDelay = 2;
    private float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);//repeatedly call SpawnRandomAnimal() method starting from 2 seconds and every 1.5 seconds
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);

        //Vector3 animalSpawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);//I changes this with below line so that animals do not spawn very close together
        Vector3 animalSpawnPos = new Vector3(Mathf.Round(Random.Range(-spawnPosX, spawnPosX)), 0, spawnPosZ);

        Instantiate(animalPrefab[animalIndex], animalSpawnPos, animalPrefab[animalIndex].transform.rotation);
    }


}
