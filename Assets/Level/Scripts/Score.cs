using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int score = 1;
    private int moves;

    void Update()
    {
        //ngl, i don't remember why I did it like this but there was a reason so pls remember it
        if(Input.GetMouseButtonDown(0))
        {
            moves = moves + 2;
            score = 10000 - (moves*2);
        }

        DisplayScore(score);

        //ends game if score hits 0 or below
        if(score <= 0)
        {
            SceneManager.LoadScene("Try Again");
        }

        //saves the latest score obtained to PlayerPrefs class for submission
        PlayerPrefs.SetInt("LatestScore",score);
    }

    //prints the score
    void DisplayScore(float score)
    {
    scoreText.text = score.ToString();
    }
}
