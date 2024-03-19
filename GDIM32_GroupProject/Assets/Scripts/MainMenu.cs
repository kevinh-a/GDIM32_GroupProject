using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame ()
    {
        SceneManager.LoadScene(7);
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(4);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }

     public void ReturnToMenu ()
    {
        SceneManager.LoadScene(0);
    }
}
