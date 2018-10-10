using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;

public class PF_SetSkinTwo : MonoBehaviour {


	public float SkinTwoUnlocked;
	public int convertedSkinTwoUnlocked;
	
	// Use this for initialization
	void Start () {
		
	SkinTwoUnlocked = PlayerPrefs.GetFloat("SkinTwoUnlocked");
	convertedSkinTwoUnlocked = Mathf.FloorToInt(SkinTwoUnlocked);
		
		
		//Note: Setting title Id here can be skipped if you have set the value in Editor Extensions already.
        if (string.IsNullOrEmpty(PlayFabSettings.TitleId)){
            PlayFabSettings.TitleId = "E73D"; // Please change this value to your own titleId from PlayFab Game Manager
        }
        var request = new LoginWithIOSDeviceIDRequest { DeviceId = "GettingStartedGuide", CreateAccount = true};
        PlayFabClientAPI.LoginWithIOSDeviceID(request, OnLoginSuccess, OnLoginFailure);
		
		

		

		
		
	}
	
	 private void OnLoginSuccess(LoginResult result)
    {
        Debug.Log("Congratulations, you made your first successful API call!");
				PlayFabClientAPI.UpdatePlayerStatistics( new UpdatePlayerStatisticsRequest {
    // request.Statistics is a list, so multiple StatisticUpdate objects can be defined if required.
    Statistics = new List<StatisticUpdate> {
        new StatisticUpdate { StatisticName = "SkinTwoUnlocked", Value = convertedSkinTwoUnlocked },
    }
},
result1 => { Debug.Log("Skin1 saved"); },
error => { Debug.LogError(error.GenerateErrorReport()); });

    }

    private void OnLoginFailure(PlayFabError error)
    {
        Debug.LogWarning("Something went wrong with your first API call.  :(");
        Debug.LogError("Here's some debug information:");
        Debug.LogError(error.GenerateErrorReport());
    }
}
