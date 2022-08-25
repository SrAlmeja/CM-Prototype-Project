using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    private float timer;
    public float timeToSpawn;
    public GameObject orb;
    public bool visibleOrb; 

    private void OnEnable()
    {
        timer = 0;
    }

    void Start()
    {
        visibleOrb = true;
    }

    private void Update()
    {
      
        if (!visibleOrb)
        {
            orb.SetActive(false);
            timer += Time.deltaTime;
            if (timer >= timeToSpawn)
            {
                visibleOrb = true;
                orb.SetActive(true);
            }    
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Me han tocado");
            visibleOrb = false;
            return;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Me dejo de tocar tocado");
            visibleOrb = false;
            return;
        }
    }
}
