using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public static bool isGrounded;
    // colliderler ile yakaladýk
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded= true;// yerdeysen 
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded= false;// yerde deðilsen etkileþimden çýktýysan yani
    }
    
}
