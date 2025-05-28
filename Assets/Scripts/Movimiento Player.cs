
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) { body.AddForce(Vector2.right * speed * Time.fixedDeltaTime); }
        if (Input.GetKey(KeyCode.A)) { body.AddForce(-Vector2.right * speed * Time.fixedDeltaTime); }
    }
}
