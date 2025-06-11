using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ui : MonoBehaviour
{
    public TextMeshProUGUI txt_points;
    public float collectiblesCount;
    public Image healthImage;
    public PlayerHealth healthPlayer;
    public Image waterImage;
    public ScreensManager SceneMAnager;

    private void Start()
    {
        waterImage.fillAmount = 0;
    }
    private void Update()
    {
        txt_points.text = "Agua Recolectada: " + collectiblesCount;
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
        if(healthImage.fillAmount <= 0)
        {
            SceneMAnager.FinalMalo();
        }
    }
}
