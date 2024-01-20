using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class UIManager : MonoBehaviour
{
    public GameObject pausePanel;
    public AudioSource clip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonEffect()
    {
        clip.Play();
    }
    public void PauseGame()
    {
        Time.timeScale = 0;// oyun dursun süre 0 olsun 
        pausePanel.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;// oyun devam etsin 
        pausePanel.SetActive(false);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenü");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
