using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
     public GameObject enemyPrefab;
      private float spawnRangeX = 10;
      private float spawnRangeZ = -10;
      public float startDelay = 2;
      public float spawnInterval = 1.5f;
      private Vector3 spawnPos = new Vector3(-1, 5, 37);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRandomAnimal()
    {
         Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
           
           
    }
}