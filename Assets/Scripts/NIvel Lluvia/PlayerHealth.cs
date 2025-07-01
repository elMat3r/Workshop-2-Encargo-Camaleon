using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth = 1;
    public Ui ui;
    void Start()
    {
        health = maxHealth;
    }
    public void HealthR()
    {
        health -= .25f;
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
