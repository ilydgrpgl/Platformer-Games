using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOfDamage : MonoBehaviour
{
    private Collider2D col;
    private Animator anim;
    private SpriteRenderer sr;
    public GameObject deathEffect;
    public int lifes = 2;
    public float jumpForce=2f;
    void Start()
    {
        col = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
        sr= GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = (Vector2.up * jumpForce);
            HealthReduce();
            CheckLife();
        }
    }
    public void HealthReduce()
    {
        lifes--;
        anim.Play("MushroomHit");
    }
    public void CheckLife()
    {
        if(lifes==0) 
        {
            deathEffect.SetActive(true);
            sr.enabled = false;
            Invoke("EnemyDie", 0.2f);
        }
    }
    public void EnemyDie()
    {
        Destroy(gameObject);
    }
}
