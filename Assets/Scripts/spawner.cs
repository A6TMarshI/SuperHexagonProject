using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnRate = 1;

    public GameObject[] hexagonPrefap;

    private float nextTimeToSpawn = 0;

    void Update()
    {
        if(Time.time>=nextTimeToSpawn)
        {
            foreach(GameObject HexagonPrefap in hexagonPrefap)
            {
                Instantiate(HexagonPrefap, Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + 1 / spawnRate;
            }
            
        }
    }
}
