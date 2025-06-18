using UnityEngine;

public class SpawnsSolcitos : MonoBehaviour
{
    [SerializeField] Transform[] spawns;
    [SerializeField] GameObject prefabSolcito;
    float count;
    public int countLimit = 2;


    // Update is called once per frame

    void Update()
    {
        count += Time.deltaTime;
        if (count >= countLimit)
        {
            int randomSpawn = Random.Range(0, spawns.Length); 
            Instantiate(prefabSolcito, spawns[randomSpawn].position, Quaternion.identity);
            count = 0;
        }
    }
}
