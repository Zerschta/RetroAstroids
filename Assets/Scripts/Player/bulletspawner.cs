using UnityEngine;

public class bulletspawner : MonoBehaviour
{    
    public GameObject bullet;
    public GameObject bulletSpawn;
    Animator animator;
    AudioSource Gunshot;

    private void Start()
    {
        animator = GetComponent<Animator>();
        Gunshot = GetComponent<AudioSource>();
    }
    void Update()
    {

        bullet.transform.position = bulletSpawn.transform.position;
        bullet.transform.rotation = transform.rotation;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Shoot");
            play();
        }
    }
    void SpawnBullet()
    {
        Instantiate(bullet);
    }
    void play()
    {
        AudioSource.PlayClipAtPoint(Gunshot.clip, transform.position);
    }
}
