using UnityEngine;

public class Vapor : MonoBehaviour
{
    public GameObject vapor;
    float duration;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        duration = vapor.GetComponent<ParticleSystem>().main.duration;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, duration);
    }
}
