using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class FruitCollection : MonoBehaviour
{
    public AudioSource clip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))// çarpýlan obje player ise
        {

            GetComponent<SpriteRenderer>().enabled = false;// direkt kendi objemiz olduðu için böyle yazdýk baþka obje olsaydý sprite renderer çaðýrmamýz gerekti.
            gameObject.transform.GetChild(0).gameObject.SetActive(true);//elmamýzýn o. childini getir ve sonra onun aktifliðini aktif yap
            LevelManager.instance.LevelCleared();// objeler temizlendiyse yeni levele geçer
            Destroy(gameObject,0.4f);//  yok edicek ikisinide direkt yok edersek efekti göremeyiz
            clip.Play();


        }
    }
   
    
}
