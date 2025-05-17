using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMAnager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            SceneManager.LoadScene("SampleScene");
        }
    }
    public void Empezar()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Final()
    {
        SceneManager.LoadScene("Final");
    }
    public void VolverMenu()
    {
        SceneManager.LoadScene("Inicio");
    }
}
