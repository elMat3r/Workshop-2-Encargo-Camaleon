using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth = 1;
    public Ui ui;


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    public void HealthR()
    {
        health -= .34f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag== "Agua")
        {
            ui.collectiblesCount++;
        }
        if(collision.collider.tag == "Rayo") { HealthR(); }
    }
}
