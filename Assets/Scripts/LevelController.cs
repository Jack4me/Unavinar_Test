using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public static LevelController instance = null;
    int sceneIndex;
    private int levelComplete;


    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComplete = PlayerPrefs.GetInt("LvlComplete");
    }

    public void IsEndGame()
    {
        if (sceneIndex == 3)
        {
            Debug.Log("ГО ТУ МЕЙН!");
            Invoke("LoadMainMenu", 5f);
        }
        else
        {
            if (levelComplete < sceneIndex)
            {
                Debug.Log("Записал");
                PlayerPrefs.SetInt("LvlComplete", sceneIndex);
            }
            else
            {
                Invoke("NextLevel", 5f);
            }
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}