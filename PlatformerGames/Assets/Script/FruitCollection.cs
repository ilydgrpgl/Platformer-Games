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
        if (collision.CompareTag("Player"))// �arp�lan obje player ise
        {

            GetComponent<SpriteRenderer>().enabled = false;// direkt kendi objemiz oldu�u i�in b�yle yazd�k ba�ka obje olsayd� sprite renderer �a��rmam�z gerekti.
            gameObject.transform.GetChild(0).gameObject.SetActive(true);//elmam�z�n o. childini getir ve sonra onun aktifli�ini aktif yap
            LevelManager.instance.LevelCleared();// objeler temizlendiyse yeni levele ge�er
            Destroy(gameObject,0.4f);//  yok edicek ikisinide direkt yok edersek efekti g�remeyiz
            clip.Play();


        }
    }
   
    
}
