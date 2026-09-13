using UnityEngine;

public class bulletspawner : MonoBehaviour
{    
    public GameObject bullet;
    public GameObject bulletSpawn;
    Animator animator;

    // Update is called once per frame

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Shoot");
        }
        
        
    }
    void SpawnBullet()
    {
        bullet.transform.position = bulletSpawn.transform.position;
        bullet.transform.rotation = transform.rotation;

        Instantiate(bullet);
    }
}
