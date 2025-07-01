using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public Termometro Termometro;
    private void Update()
    {
        if (Termometro.imageTermometro.fillAmount == 1)
        {
            SceneManager.LoadScene("Final");
        }
        if (Termometro.imageTermometro.fillAmount == 0)
        {
            SceneManager.LoadScene("Final Malo");
        }
    }
}
