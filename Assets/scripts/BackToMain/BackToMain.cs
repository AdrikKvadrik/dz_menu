using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true; 
            Cursor.lockState = CursorLockMode.None; 
            SceneManager.LoadScene("MainMenu");
        }
    }
}
