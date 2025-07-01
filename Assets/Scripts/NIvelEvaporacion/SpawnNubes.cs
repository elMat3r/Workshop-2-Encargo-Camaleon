using UnityEngine;

public class SpawnNubes : MonoBehaviour
{
    public float nubeRate;
    public GameObject nubePrefab;
    public Transform[] spawnNubes;



    private void Update()
    {
        if(nubeRate == 3)
        {
            int spawn = Random.Range(0, spawnNubes.Length);
            print(spawn);
            Instantiate(nubePrefab, spawnNubes[spawn]);
            nubeRate = 0;
           
        }
    }
}
