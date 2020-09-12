using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OpenGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OpenCustomization()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }
}
