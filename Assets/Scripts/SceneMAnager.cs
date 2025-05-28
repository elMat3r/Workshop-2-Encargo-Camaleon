using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMAnager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            SceneManager.LoadScene("Gameplay");
        }
    }
    public void Empezar()
    {
        SceneManager.LoadScene("Gameplay");
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
