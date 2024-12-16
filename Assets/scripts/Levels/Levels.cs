using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Levels : MonoBehaviour
{
    public void level1()
    {
    SceneManager.LoadScene("level1");
    }

    public void level2()
    {
    SceneManager.LoadScene("level2");
    }

    public void level3()
    {
    SceneManager.LoadScene("level3");
    }

    public void Back()
    {
    SceneManager.LoadScene("MainMenu");
    }
}

