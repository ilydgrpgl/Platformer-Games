using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public GameObject levelTrans; 
    //singleten pattern
    public static LevelManager instance;
    public Text totalFruits;
    public Text remainFruits;

    LevelSelect selection;


    public void Start()
    {
        selection = GetComponent<LevelSelect>();
        totalFruits.text=transform.childCount.ToString();
    }
    
    public void Awake()
    {
        instance = this;
        
    }

    public void LevelCleared()
    {
        if(transform.childCount == 1)
        {
            levelTrans.SetActive(true);
            StartCoroutine(Waiting());
            selection.GetLevelIndex();
            
        }
        
    }
    private void Update()
    {
        remainFruits.text = transform.childCount.ToString();
    }
    void ChangeLevel()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(1.2f);// 1.2 saniye bekledikten sonra levek deðiþtir yoksa effect oynamaz
        ChangeLevel() ;
    }
}
