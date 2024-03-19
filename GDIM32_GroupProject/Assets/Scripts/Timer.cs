using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Jasmine Chen

public class Timer : MonoBehaviour
{

    public float totalTime = 120f; 
    private float currentTime;
    public Text timerText;
    private bool gameOver = false;

    void Start()
    {
        currentTime = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerDisplay();
        } 
        if (currentTime <= 0f)
            {
                GameOver();
            }
    }

    private void UpdateTimerDisplay()
    {
        if (timerText != null)
        {
            timerText.text = "Time Remaining: " + Mathf.CeilToInt(currentTime).ToString() + "s";
        }
    }

    private void GameOver()
    {
        Debug.Log("Game Over");
        gameOver = true;

        SceneManager.LoadScene(4);
    }
}
