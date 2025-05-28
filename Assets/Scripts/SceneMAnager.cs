using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay");
        }
    }
    public void Empezar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay");
    }
    public void Final()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Final");
    }
    public void VolverMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Inicio");
    }
    public void FinalMalo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Final Malo");
    }
}
