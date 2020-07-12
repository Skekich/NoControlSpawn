using System;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> spawns = new List<GameObject>();

    private void Update()
    {
        if (!(Input.GetKeyDown(KeyCode.S))) return;
        var spawNumber = UnityEngine.Random.Range(0, spawns.Count);
        var toSpawn = spawns[spawNumber];
        Instantiate(toSpawn, transform.position, Quaternion.identity);
    }
}