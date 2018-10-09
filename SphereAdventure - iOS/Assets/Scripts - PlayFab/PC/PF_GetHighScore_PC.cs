using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;

public class PF_GetHighScore_PC : MonoBehaviour {

	public float HighScoreFromLeaderBoard;
	public int ScoreAsInt;
	private Text playerScore;
	public string ScoreAsString;

	// Use this for initialization
	public void Start()
    {
        //Note: Setting title Id here can be skipped if you have set the value in Editor Extensions already.
        if (string.IsNullOrEmpty(PlayFabSettings.TitleId)){
            PlayFabSettings.TitleId = "144"; // Please change this value to your own titleId from PlayFab Game Manager
        }
        var request = new LoginWithCustomIDRequest { CustomId = "GettingStartedGuide", CreateAccount = true};
        PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginFailure);
    }

    private void OnLoginSuccess(LoginResult result1)
    {
        Debug.Log("Logged In");
		
		PlayFabClientAPI.GetPlayerStatistics(new GetPlayerStatisticsRequest()
{ StatisticNames = new List<string> { "HighScore"// <- My Leaderboard name
}},result =>{Debug.Log("Complete " + result.ToString());

if (result.Statistics[0] != null)

	ScoreAsString = string.Format("" + result.Statistics[0].Value);},
	
	//playerScore.text = string.Format("Score: " + result.Statistics[0].Value);},

error => Debug.Log(error.GenerateErrorReport()));
		
    }

    private void OnLoginFailure(PlayFabError error)
    {
        Debug.LogWarning("Something went wrong with your first API call.  :(");
        Debug.LogError("Here's some debug information:");
        Debug.LogError(error.GenerateErrorReport());
    }
	
	private void Update()
	{
		
		ScoreAsInt = int.Parse(ScoreAsString);
		HighScoreFromLeaderBoard = (float)ScoreAsInt;
		PlayerPrefs.SetFloat("HighScore",HighScoreFromLeaderBoard);
		
	}
}