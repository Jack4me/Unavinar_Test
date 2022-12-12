using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button lvlButton2;
    public Button lvlButton3;
    private int lvlComplete;

    private void Start()
    {
        lvlComplete = PlayerPrefs.GetInt("LvlComplete");
        lvlButton2.interactable = false;
        lvlButton3.interactable = false;

        switch (lvlComplete)
        {
            case 1:
                lvlButton2.interactable = true;
                break;
            case 2:
                lvlButton2.interactable = true;
                lvlButton3.interactable = true;
                break;
        }
    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Reset()
    {
        lvlButton2.interactable = false;
        lvlButton3.interactable = false;
        PlayerPrefs.DeleteAll();
    }

    
}