using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] preFabs;
    public Transform[] spawns;
    public float countLimit;
    float count = 0;


    private void Update()
    {
        count = count += Time.deltaTime;

        if(count > countLimit)
        {
            count = 0;
            int prefabRandom = Random.Range(0, preFabs.Length);
            int spawnRandom = Random.Range(0, spawns.Length);

            Instantiate(preFabs[prefabRandom], spawns[spawnRandom].position, Quaternion.identity);
        }
    }
}
