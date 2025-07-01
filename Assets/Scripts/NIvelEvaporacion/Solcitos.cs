using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class Solcitos : MonoBehaviour
{
    [SerializeField] float spd;
    [SerializeField] Rigidbody2D rb;
    int limitSpd;
    public Termometro termometro;
    public GameObject vapor;
    SpawnNubes spawnNubes;



    private void Start()
    {
        spawnNubes = FindAnyObjectByType<SpawnNubes>();
        termometro = FindAnyObjectByType<Termometro>();
        rb = GetComponent<Rigidbody2D>();
        limitSpd = Random.Range(-4, -10);
        rb.gravityScale = Random.Range(.3f, .5f);
        spd = Random.Range(2, 4);
        rb.AddForce(Vector2.left * spd, ForceMode2D.Impulse);
    }



    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.collider.tag == "Suelo" )
        {
            Destroy(gameObject);
        } 
        if(collision.collider.tag == "Agua")
        {
            termometro.TempTermometro();
            Instantiate(vapor);
            spawnNubes.nubeRate++;
            Destroy(gameObject);

        }
    }
}
