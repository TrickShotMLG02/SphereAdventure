using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;

public class PF_GetTotalGems : MonoBehaviour {

	public float CoinsFromLeaderBoard;
	public int CoinsAsInt;
	private Text playerCoins;
	public string CoinsAsString;

	// Use this for initialization
	public void Start()
    {
        //Note: Setting title Id here can be skipped if you have set the value in Editor Extensions already.
        if (string.IsNullOrEmpty(PlayFabSettings.TitleId)){
            PlayFabSettings.TitleId = "144"; // Please change this value to your own titleId from PlayFab Game Manager
        }
        var request = new LoginWithIOSDeviceIDRequest { DeviceId = "GettingStartedGuide", CreateAccount = true};
        PlayFabClientAPI.LoginWithIOSDeviceID(request, OnLoginSuccess, OnLoginFailure);
    }

    private void OnLoginSuccess(LoginResult result1)
    {
        Debug.Log("Logged In");
		
		PlayFabClientAPI.GetPlayerStatistics(new GetPlayerStatisticsRequest()
{ StatisticNames = new List<string> { "Coins"// <- My Leaderboard name
}},result =>{Debug.Log("Complete " + result.ToString());

if (result.Statistics[0] != null)

	CoinsAsString = string.Format("" + result.Statistics[0].Value);},
	
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
		
		CoinsAsInt = int.Parse(CoinsAsString);
		CoinsFromLeaderBoard = (float)CoinsAsInt;
		PlayerPrefs.SetFloat("Gems",CoinsFromLeaderBoard);
		
	}
}