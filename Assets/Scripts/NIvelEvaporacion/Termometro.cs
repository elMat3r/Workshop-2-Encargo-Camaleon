using UnityEngine;
using UnityEngine.UI;

public class Termometro : MonoBehaviour
{
    public   Image imageTermometro;

    
    public void TempTermometro()
    {
        imageTermometro.fillAmount += .10f; 
    }

    private void Update()
    {
        imageTermometro.fillAmount -= .00005f;
       
           
        
    }






}
