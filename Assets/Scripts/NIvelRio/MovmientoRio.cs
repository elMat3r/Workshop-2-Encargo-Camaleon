using UnityEngine;

public class MovmientoRio : MonoBehaviour
{

    public float spdRio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.position += transform.right * -spdRio * Time.deltaTime;
    }
}
