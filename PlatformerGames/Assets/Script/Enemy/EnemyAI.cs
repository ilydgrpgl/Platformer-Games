using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Animator anim;
    private SpriteRenderer sr;
    public float speed = .5f;
    private float waitTime;
    public Transform[] movingSpot;
    public float startWaitingTime = 3;
    private int i;
    private Vector2 currentPos;

    
    void Start()
    {
        waitTime = startWaitingTime;
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
       
    }

    void Update()
    {
        StartCoroutine(CheckWaiting());
        transform.position = Vector2.MoveTowards(transform.position, movingSpot[i].transform.position, speed * Time.deltaTime);

        

        if (Vector2.Distance(transform.position, movingSpot[i].transform.position) < 0.1f)
        {
            if (waitTime <= 0)
            {
                if (movingSpot[i] != movingSpot[movingSpot.Length - 1])
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
                waitTime = startWaitingTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }

    
     IEnumerator CheckWaiting()
     {
         currentPos = transform.position;
        yield return new WaitForSeconds(0.5f);

         if (transform.position.x > currentPos.x)// saða gidiyorsa 
         {
             sr.flipX = true;
             anim.SetBool("Idle", false);// run çalýþsýn demek
         }
         else if (transform.position.x < currentPos.x)
         {
             sr.flipX=false;
             anim.SetBool("Idle", false);// run çalýþsýn demek
         }
         else if(transform.position.x==currentPos.x)
             {
             anim.SetBool("Idle",true);// ýdle çalýþsýn demek

         }
     }
}

