using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocalvsButtons : MonoBehaviour
{
    // Goes to Local Multiplayer Scene
    public void LocalMultiplayer()
    {
        SceneManager.LoadScene(3);
    }

    // Goes to online multiplayer matchmaking
    public void OnlineMultiplayer()
    {
        SceneManager.LoadScene(2);
    }
}
