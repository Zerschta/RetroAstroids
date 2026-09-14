using UnityEngine;


public class ScoreLogic : MonoBehaviour
{

    public GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Astroid") || collision.collider.CompareTag("CrackedAstroid"))
        {
            gameManager.AddScore(120);
        }
    }
}
