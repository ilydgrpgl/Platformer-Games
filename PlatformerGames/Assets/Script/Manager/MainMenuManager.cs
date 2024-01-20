using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenuManager : MonoBehaviour
{
    public GameObject panel;
    public AudioSource clip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonClickEffect()
    {
        clip.Play();
    }
    public void Settings()
    {
        panel.GetComponent<Animator>().SetTrigger("Pop");
    }
    public void StartGame()//tuþ
    {
        Invoke("WaitTime", 0.5f);
        
    }
    public void WaitTime()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    public void QuitGame()
    {
        Application.Quit();  
    }
}
