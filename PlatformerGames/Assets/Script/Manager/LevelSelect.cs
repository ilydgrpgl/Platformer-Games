using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    
    public void GetLevelIndex()
    {
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentLevelIndex >= PlayerPrefs.GetInt("CurrentLevel"))// burada o oluyor current level
        {
            PlayerPrefs.SetInt("CurrentLevel", currentLevelIndex + 1);
        }
        // level select managerde yaptýðýmýz levelin artmasý saðlanýyor.
    }
}
