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
            // Burada waitTime'ý doðru þekilde azaltýn.
            waitTime -= Time.deltaTime;
        }
    }

    public void LaunchBullet()
    {
        // Bullet'ý doðru bir þekilde oluþturun ve launchPoint pozisyonuna yerleþtirin.
        Instantiate(bulletPref, launchPoint.position, launchPoint.rotation);
    }
}
