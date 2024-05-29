using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRange = 2;
    public int enemyCount;
    public int waveNumber = 1;
    private float StartDelay = 2;
    private float spawnInterval = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        InvokeRepeating("EnemySpawnTime", StartDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
        
        
    }
    private Vector3 GenerateSpawnPosition () {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
    void EnemySpawnTime(){
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        
    }
    
}
