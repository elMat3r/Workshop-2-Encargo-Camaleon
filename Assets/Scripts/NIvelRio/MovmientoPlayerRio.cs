using UnityEngine;
using UnityEngine.SceneManagement;

public class MovmientoPlayerRio : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.y <= 1.74)
        {
            movement.y = Input.GetAxisRaw("Vertical");

        }
            movement.x = Input.GetAxisRaw("Horizontal");

        movement = movement.normalized;
    }

    void FixedUpdate()
    {
        float movX = transform.position.x;
        
            rb.linearVelocity = movement * moveSpeed;

        
        if(transform.position.y >= 1.74)
        {
            transform.position = new Vector2(movX , 1.70f);
        }
        
        
        
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Piedras")
        {

            Destroy(collision.collider.gameObject);
        }
        if(collision.collider.tag == "Meta")
        {
            SceneManager.LoadScene("Final");
        }
    }
}
