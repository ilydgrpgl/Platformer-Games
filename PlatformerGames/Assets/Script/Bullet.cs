using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2f;
    public float lifesTime = 3f;
    public bool left;
    void Start()
    {
        Destroy(gameObject,lifesTime);
    }

    // Update is called once per frame
    void Update()
    {
        if(left)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
