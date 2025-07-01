using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class Solcitos : MonoBehaviour
{
    [SerializeField] float spd;
    [SerializeField] Rigidbody2D rb;
    int limitSpd;
    public Termometro termometro;
    public GameObject vapor;



    private void Start()
    {
        termometro = FindAnyObjectByType<Termometro>();
        rb = GetComponent<Rigidbody2D>();
        limitSpd = Random.Range(-4, -10);
        rb.gravityScale = Random.Range(.3f, .5f);
        spd = Random.Range(2, 4);
        rb.AddForce(Vector2.left * spd, ForceMode2D.Impulse);
    }



    private void Update()
    {
        //if (rb.linearVelocityX >= limitSpd )
        //{
        //    rb.AddForce(new Vector2(-1f, 0f) * spd, ForceMode2D.Impulse);

        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.collider.tag == "Suelo" )
        {
            Destroy(gameObject);
        } 
        if(collision.collider.tag == "Agua")
        {
            Destroy(gameObject);
            termometro.TempTermometro();
            Instantiate(vapor);
        }
    }
}
