using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealthRio : MonoBehaviour
{
    public Image HealthImage;
    public float maxHealth = 100;
    public float currentHealth;


    private void Start()
    {
        currentHealth = maxHealth;
    }
    private void Update()
    {
        if(currentHealth <= 0)
        {
            SceneManager.LoadScene("Final Malo");
        }
    }
    public void RockCollision()
    {
        currentHealth -= 34;
        HealthImage.fillAmount -= .34f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Piedras")
        {
            RockCollision();
        }
    }

    
 }
