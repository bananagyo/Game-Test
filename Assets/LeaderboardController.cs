using UnityEngine;
using UnityEngine.UI;
using LootLocker.Requests;
using System.Collections.Generic;

public class LeaderboardController : MonoBehaviour
{
    public InputField MemberID, PlayerScore;
    public string ID;
    int MaxScores = 7;
    public Text[] Entries;

    //Starts, acceses, and validates lootlocker SDK
    private void Start()
    {
        LootLockerSDKManager.StartSession("User", (response) => 
        {
            if(response.success)
            {
                Debug.Log("Success");
            }
            else
            {
                Debug.Log("Failed");
            }
        });
    }

    //Gets all the scores into an array, then prints
    public void ShowScores()
    {
        LootLockerSDKManager.GetScoreList(ID, MaxScores, (response) =>
        {
            
            if(response.success)
            {
                if (response.success)
                {
                    // DON'T TOUCH THIS ARRAY DECLARATION I BEG
                    LootLocker.Requests.LootLockerLeaderboardMember[] scores = response.items;

                    for (int i = 0; i < scores.Length; i++)
                    {
                        Entries[i].text = (scores[i].rank + ".   " + scores[i].score);
                    }

                    if (scores.Length < MaxScores)
                    {
                        for (int i = scores.Length; i < MaxScores; i++)
                        {
                            Entries[i].text = (i + 1).ToString() + ".   none";
                        }
                    }
                }
            }

            //checks if it didn't work
            else
            {
                Debug.Log("Failed");
            }
        });
    }

    //submit button, player can add thier score to the online leaderboard
    public void SubmitScore()
    {
        LootLockerSDKManager.SubmitScore(MemberID.text, PlayerPrefs.GetInt("LatestScore"), ID, (response) =>
        {
            if(response.success)
            {
                Debug.Log("Success");
            }
            else
            {
                Debug.Log("Failed");
            }
        });
    }
}


