using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ui : MonoBehaviour
{
    public Text txt;
    public float collectiblesCount;
    public Image healthImage;
    public PlayerHealth healthPlayer;
    public Image waterImage;
    public SceneMAnager SceneMAnager;

    private void Start()
    {
        waterImage.fillAmount = 0;
    }
    private void Update()
    {
        txt.text = "Agua Recolectada: " + collectiblesCount;
        healthImage.fillAmount = healthPlayer.health;

        if(collectiblesCount >= 5)
        {
            waterImage.fillAmount += .20f;
            collectiblesCount = 0;
        }
        if(waterImage.fillAmount >= 1)
        {
            SceneMAnager.Final();
        }

    }


}
