using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
            timerText.text = Mathf.CeilToInt(currentTime).ToString(); // Display the remaining time
        }
    }

    private void GameOver()
    {
        Debug.Log("Game Over");
        gameOver = true;

        // SceneManager.LoadScene("GameOverScene");
    }
}
