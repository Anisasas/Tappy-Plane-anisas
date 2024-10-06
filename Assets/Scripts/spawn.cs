using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2;
    public float lastSpawnTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > lastSpawnTime + spawnRate)
        {
            Instantiate (pipePrefab);
            lastSpawnTime = Time.time;
        }
    }
}
