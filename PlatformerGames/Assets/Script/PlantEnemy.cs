using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantEnemy : MonoBehaviour
{
    private float waitTime;
    public float waitiTimeAttack = 2;
    Animator anim;
    public GameObject bulletPref;
    public Transform launchPoint;

    void Start()
    {
        anim = GetComponent<Animator>();
        waitTime = waitiTimeAttack;
    }


    void Update()
    {
        if (waitTime <= 0)
        {
            waitTime = waitiTimeAttack;
            anim.Play("Attack");
            Invoke("LaunchBullet", 0.3f);
        }
        else
        {
            // Burada waitTime'� do�ru �ekilde azalt�n.
            waitTime -= Time.deltaTime;
        }
    }

    public void LaunchBullet()
    {
        // Bullet'� do�ru bir �ekilde olu�turun ve launchPoint pozisyonuna yerle�tirin.
        Instantiate(bulletPref, launchPoint.position, launchPoint.rotation);
    }
}
