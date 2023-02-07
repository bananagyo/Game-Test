using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;
    public float score = 0;
    public int highScore = 0;
    string highScoreKey = "HighScore";


    public void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        highScore = PlayerPrefs.GetInt(highScoreKey,0);
    }

    void Update()
    {
        //need to delete old scoring system
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
                score = 1000000 - Time.deltaTime*100;
            }
            else
            {
                //Ends game when time is up
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                score = 1000000 - Time.deltaTime*100;
                SceneManager.LoadScene("Try Again");

            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        //Converting seconds to digital clock time maths
    timeToDisplay += 1;
    float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
    float seconds = Mathf.FloorToInt(timeToDisplay % 60);
    timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    //prints the stuff
    void DisplayScore(float score)
    {
    timeText.text = score.ToString();
    }


    //delete later, old scoring system
    //careful don't mess up player prefs
    void OnDisable(){
        if(score>highScore){
            PlayerPrefs.SetFloat(highScoreKey, score);
            PlayerPrefs.Save();
        }
     }
}