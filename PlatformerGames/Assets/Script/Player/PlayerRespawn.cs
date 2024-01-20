using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
   Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();  
    }

    
    public void PlayerDamaged()
    {
        anim.SetTrigger("Hit");// animasyonu �al��t�r

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
