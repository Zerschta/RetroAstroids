using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DamagePlayerSystem : MonoBehaviour
{
    [SerializeField] private SpriteRenderer Full;
    [SerializeField] private SpriteRenderer HalfLife;
    [SerializeField] private SpriteRenderer Dead;

    [SerializeField] private RawImage Right;
    [SerializeField] private RawImage Mid;
    [SerializeField] private RawImage Left;
    
    public GameObject explode;
    public int DamageValue;
    void Start()
    {
        DamageValue = 0;
        Full.enabled = true;
        HalfLife.enabled = false;
        Dead.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Astroid") || collision.collider.gameObject.CompareTag("CrackedAstroid"))
        {
            DamageValue++;

            Destroy(collision.collider.gameObject);
            explode.transform.position = collision.GetContact(0).point;
            Instantiate(explode);

            damageSystem();
        }
    }

    void damageSystem() {
        if (DamageValue == 0)
        {
            Full.enabled = true;
            HalfLife.enabled = false;
            Dead.enabled = false;

            Left.enabled = true;
            Right.enabled = true;
            Mid.enabled = true;
        }
        else if (DamageValue == 1)
        {
            Full.enabled = false;
            HalfLife.enabled = true;
            Dead.enabled = false;
            Right.enabled = false;
        }
        else if (DamageValue == 2)
        {
            Full.enabled = false;
            HalfLife.enabled = false;
            Dead.enabled = true;
            Mid.enabled = false;
        }
        else if (DamageValue == 3)
        {
            Destroy(gameObject);
            IsDead.Isdead = true;
            Left.enabled = false;
        }
    }
}
