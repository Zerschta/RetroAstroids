using UnityEngine;

public class bulletmovement : MonoBehaviour
{

    Rigidbody2D rb;

    public GameManager gameManager;
    public float Speed;
    public GameObject explode;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {       
        CheckCorner();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = transform.up * Speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    { 
        explode.transform.position = collision.GetContact(0).point;
        Instantiate(explode);
        Destroy(gameObject);

        if (collision.collider.CompareTag("Astroid") || collision.collider.CompareTag("CrackedAstroid"))
        {
            gameManager.AddScore(120);
        }
    }

    void CheckCorner() {
        if (transform.position.x <= -14 || transform.position.x >= 14)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y <= -7 || transform.position.y >= 7) { 
            Destroy(gameObject);
        }
    }
}
