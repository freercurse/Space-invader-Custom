using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnForCombat : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject[] Spawners;    
    [SerializeField] int spawnMin = 1;
    [SerializeField] int spawnMax = 3;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawn", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn()
    {
        Debug.Log("Spawning");
        int RandomSpawn = UnityEngine.Random.Range(spawnMin, spawnMax);
        int RandomSpawner = UnityEngine.Random.Range(0, 5);          
        
         Debug.Log("1 has spawned");          
        Instantiate(Enemy, Spawners[RandomSpawner].transform.position, transform.rotation);

        Invoke("spawn", RandomSpawn);   
    }
}
