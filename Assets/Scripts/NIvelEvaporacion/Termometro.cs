using UnityEngine;
using UnityEngine.UI;

public class Termometro : MonoBehaviour
{
    public   Image imageTermometro;
    public float restaTermometro;

    
    public void TempTermometro()
    {
        imageTermometro.fillAmount += .05f; 
    }

    private void Update()
    {
        imageTermometro.fillAmount -= restaTermometro;
       
           
        
    }






}
