using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScreensManager : MonoBehaviour
{
    public GameObject panelNiveles;
    public GameObject botonEmpezar;
    public string siguenteNivel;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            SceneManager.LoadScene("Gameplay");
        }
    }
    public void Empezar()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay");
        panelNiveles.SetActive(true);
        botonEmpezar.SetActive(false);

    }
    public void VolverPanelNiveles()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay");
        panelNiveles.SetActive(false);
        botonEmpezar.SetActive(true);

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
    public void NivelLluvia()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TransLluvia");
        panelNiveles.SetActive(true);
        botonEmpezar.SetActive(false);

    }
    public void NivelEvaporacion()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TransEva");
        panelNiveles.SetActive(true);
        botonEmpezar.SetActive(false);

    }
    public void NivelRio()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("TransRio");
        panelNiveles.SetActive(true);
        botonEmpezar.SetActive(false);

    }
    public void Nivel4()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Nivel 4 (No Decidido)");
        panelNiveles.SetActive(true);
        botonEmpezar.SetActive(false);

    }

    public void SiguienteNivel()
    {
        SceneManager.LoadScene(siguenteNivel);
    }
    
}
