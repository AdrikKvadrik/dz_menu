using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void LevelsScr()
    {
    SceneManager.LoadScene("Levels");
    }

    public void Play()
    {
    SceneManager.LoadScene("level1");
    }

    public void Quit()
    {
    Application.Quit();
    }
}

