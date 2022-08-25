using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnOrb : MonoBehaviour
{
    public GameObject orbToInstantiate;
    public GameObject orb;
    public List<Transform> spawnZones;

    private float timer;
    public float timeToSpawn;
    private float spawnProbavility;
    private int randomIndex;
    private GameObject selectedSpawnZone;
    private bool visibleOrb; 

    private void OnEnable()
    {
        timer = 0;
    }

    private void Awake()
    {
        randomIndex = 0;
    }

    void Start()
    {
        Instantiate(orbToInstantiate);
        visibleOrb = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!visibleOrb)
        {
            timer += Time.deltaTime;
            if (timer >= timeToSpawn)
            {
                Debug.Log("Me han instanciado");
                SpawnCalculator();
                visibleOrb = true;
            }    
        }
    }

    void SpawnCalculator()
    {
        randomIndex = Random.Range(0, spawnZones.Count);
        Debug.Log(randomIndex);
    }
    
    
}
