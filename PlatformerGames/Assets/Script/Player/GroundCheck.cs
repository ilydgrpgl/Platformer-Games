using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public static bool isGrounded;
    // colliderler ile yakalad�k
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded= true;// yerdeysen 
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded= false;// yerde de�ilsen etkile�imden ��kt�ysan yani
    }
    
}
