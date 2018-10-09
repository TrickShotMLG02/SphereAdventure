using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;

public class ShopControllerNew : MonoBehaviour {
	
	public float Gems;
	
	public float SkinOnePrice;
	public float SkinOneBought = 0f;
	public bool SkinOneSelected;
	public int convertedSkinOneUnlocked;
	
	public float SkinTwoPrice;
	public float SkinTwoBought = 0f;
	public bool SkinTwoSelected;
	public int convertedSkinTwoUnlocked;
	
	public float SkinThreePrice;
	public float SkinThreeBought = 0f;
	public bool SkinThreeSelected;
	public int convertedSkinThreeUnlocked;
	
	
	public Button SkinOneButton;
	public Button SkinTwoButton;
	public Button SkinThreeButton;
	
	public bool btnOneIsPressed;
	public bool btnTwoIsPressed;
	public bool btnThreeIsPressed;
	
	public Text SkinOne;
	public Text SkinTwo;
	public Text SkinThree;
	
	public float Const = 1.0f;
	
	public float PlayerPrefs1;
	public float PlayerPrefs2;
	public float PlayerPrefs3;
	
	// Use this for initialization
	void Start () {
		
		SkinOneBought = PlayerPrefs.GetFloat("SkinOneUnlocked");
		SkinTwoBought = PlayerPrefs.GetFloat("SkinTwoUnlocked");
		SkinThreeBought = PlayerPrefs.GetFloat("SkinThreeUnlocked");
		
		PlayerPrefs1 = PlayerPrefs.GetFloat("SkinOneUnlocked");
		PlayerPrefs2 = PlayerPrefs.GetFloat("SkinTwoUnlocked");
		PlayerPrefs3 = PlayerPrefs.GetFloat("SkinThreeUnlocked");
		
		
		
		
		Button btnOne = SkinOneButton.GetComponent<Button>();
		Button btnTwo = SkinTwoButton.GetComponent<Button>();
		Button btnThree = SkinThreeButton.GetComponent<Button>();
		
		Gems = PlayerPrefs.GetFloat("Gems");
		
		
		btnOne.onClick.AddListener(SkinOneBuy);
		btnTwo.onClick.AddListener(SkinTwoBuy);
		btnThree.onClick.AddListener(SkinThreeBuy);
		
		convertedSkinOneUnlocked = Mathf.FloorToInt(SkinOneBought);
		convertedSkinTwoUnlocked = Mathf.FloorToInt(SkinTwoBought);
		convertedSkinThreeUnlocked = Mathf.FloorToInt(SkinThreeBought);
		
		
		
		if(SkinOneBought == 1)
		{
			SkinOne.text = "Select";
		}	
		
		if(SkinTwoBought == 1)
		{
			SkinTwo.text = "Select";
		}
			
		if(SkinThreeBought == 1)
		{
			SkinThree.text = "Select";
		}
		
		
		
		
		
	}
	
	void SkinOneBuy () {
		
		if(SkinOneBought == 1)
		{	
			SkinOneSelected = true;
			PlayerPrefs.SetFloat("SkinSelected", 1);
			SkinTwoSelected = false;
			SkinThreeSelected = false;
			SkinOne.text = "Selected";
			
			
			if (string.IsNullOrEmpty(PlayFabSettings.TitleId)){
            PlayFabSettings.TitleId = "E73D"; // Please change this value to your own titleId from PlayFab Game Manager
        }
        var request = new LoginWithIOSDeviceIDRequest { DeviceId = "GettingStartedGuide", CreateAccount = true};
        PlayFabClientAPI.LoginWithIOSDeviceID(request, OnLoginSuccess1, OnLoginFailure1);
			
			
			if(SkinTwoBought == 1)
		{
			SkinTwo.text = "Select";
		}
			
			if(SkinThreeBought == 1)
		{
			SkinThree.text = "Select";
		}
		}
		else if(SkinOneBought == 0)
		{	
		if(Gems >= SkinOnePrice)
		{	
			Gems = Gems - SkinOnePrice;
			PlayerPrefs.SetFloat("Gems", Gems);
			SkinOneBought = 1.0f;
			PlayerPrefs.SetFloat("SkinOneUnlocked", Const);
			
			SkinOneSelected = true;
			PlayerPrefs.SetFloat("SkinSelected", 1);
			
			
			if (string.IsNullOrEmpty(PlayFabSettings.TitleId)){
            PlayFabSettings.TitleId = "E73D"; // Please change this value to your own titleId from PlayFab Game Manager
        }
        var request = new LoginWithIOSDeviceIDRequest { DeviceId = "GettingStartedGuide", CreateAccount = true};
        PlayFabClientAPI.LoginWithIOSDeviceID(request, OnLoginSuccess1, OnLoginFailure1);
			
			
			
			
			SkinTwoSelected = false;
			SkinThreeSelected = false;
			SkinOne.text = "Selected";
			
			if(SkinTwoBought == 1)
			{
			SkinTwo.text = "Select";
			}
			
			if(SkinThreeBought == 1)
			{
			SkinThree.text = "Select";
			}
			
		}
		
		}
	}
	
	
	void SkinTwoBuy () {
		
		if(SkinTwoBought == 1)
		{	
			SkinTwoSelected = true;
			SkinOneSelected = false;
			SkinThreeSelected = false;
			SkinTwo.text = "Selected";
			PlayerPrefs.SetFloat("SkinSelected", 2);
			
			if(SkinOneBought == 1)
		{
			SkinOne.text = "Select";
		}
			
			if(SkinThreeBought == 1)
		{
			SkinThree.text = "Select";
		}
		}
		else if(SkinTwoBought == 0)
		{	
		if(Gems >= SkinTwoPrice)
		{	
			Gems = Gems - SkinTwoPrice;
			PlayerPrefs.SetFloat("Gems", Gems);
			PlayerPrefs.SetFloat("SkinTwoUnlocked", Const);
			SkinTwoBought = 1;
			SkinTwoSelected = true;
			SkinOneSelected = false;
			SkinThreeSelected = false;
			SkinTwo.text = "Selected";
			PlayerPrefs.SetFloat("SkinSelected", 2);
			
			
			if (string.IsNullOrEmpty(PlayFabSettings.TitleId)){
            PlayFabSettings.TitleId = "E73D"; // Please change this value to your own titleId from PlayFab Game Manager
        }
        var request = new LoginWithIOSDeviceIDRequest { DeviceId = "GettingStartedGuide", CreateAccount = true};
        PlayFabClientAPI.LoginWithIOSDeviceID(request, OnLoginSuccess2, OnLoginFailure2);
		
			
			if(SkinOneBought == 1)
			{
			SkinOne.text = "Select";
			}
			
			if(SkinThreeBought == 1)
			{
			SkinThree.text = "Select";
			}
			
		}
		}
	}

	void SkinThreeBuy () {
		
		if(SkinThreeBought == 1)
		{	
			SkinThreeSelected = true;
			SkinOneSelected = false;
			SkinOneSelected = false;
			SkinThree.text = "Selected";
			PlayerPrefs.SetFloat("SkinSelected", 3);
			
			if(SkinTwoBought == 1)
		{
			SkinTwo.text = "Select";
		}
			
			if(SkinOneBought == 1)
		{
			SkinOne.text = "Select";
		}
		}
		else if(SkinThreeBought == 0)
		{	
		if(Gems >= SkinThreePrice)
		{	
			Gems = Gems - SkinThreePrice;
			PlayerPrefs.SetFloat("Gems", Gems);
			PlayerPrefs.SetFloat("SkinThreeUnlocked", Const);
			SkinThreeBought = 1;
			SkinThreeSelected = true;
			SkinOneSelected = false;
			SkinTwoSelected = false;
			SkinThree.text = "Selected";
			PlayerPrefs.SetFloat("SkinSelected", 3);
			
			
			if (string.IsNullOrEmpty(PlayFabSettings.TitleId)){
            PlayFabSettings.TitleId = "E73D"; // Please change this value to your own titleId from PlayFab Game Manager
        }
        var request = new LoginWithIOSDeviceIDRequest { DeviceId = "GettingStartedGuide", CreateAccount = true};
        PlayFabClientAPI.LoginWithIOSDeviceID(request, OnLoginSuccess3, OnLoginFailure3);
			
			
			if(SkinOneBought == 1)
			{
			SkinOne.text = "Select";
			}
			
			if(SkinTwoBought == 1)
			{
			SkinTwo.text = "Select";
			}
			
		}	
		}
	}
	
	
	private void OnLoginSuccess1(LoginResult result)
    {
        Debug.Log("Congratulations, you made your first successful API call!");
				PlayFabClientAPI.UpdatePlayerStatistics( new UpdatePlayerStatisticsRequest {
    // request.Statistics is a list, so multiple StatisticUpdate objects can be defined if required.
    Statistics = new List<StatisticUpdate> {
        new StatisticUpdate { StatisticName = "SkinOneUnlocked", Value = convertedSkinOneUnlocked },
    }
},
result1 => { Debug.Log("Skin1 saved"); },
error => { Debug.LogError(error.GenerateErrorReport()); });

    }

    private void OnLoginFailure1(PlayFabError error)
    {
        Debug.LogWarning("Something went wrong with your first API call.  :(");
        Debug.LogError("Here's some debug information:");
        Debug.LogError(error.GenerateErrorReport());
    }
	
	
	private void OnLoginSuccess2(LoginResult result)
    {
        Debug.Log("Congratulations, you made your first successful API call!");
				PlayFabClientAPI.UpdatePlayerStatistics( new UpdatePlayerStatisticsRequest {
    // request.Statistics is a list, so multiple StatisticUpdate objects can be defined if required.
    Statistics = new List<StatisticUpdate> {
        new StatisticUpdate { StatisticName = "SkinTwoUnlocked", Value = convertedSkinTwoUnlocked },
    }
},
result1 => { Debug.Log("Skin2 saved"); },
error => { Debug.LogError(error.GenerateErrorReport()); });

    }

    private void OnLoginFailure2(PlayFabError error)
    {
        Debug.LogWarning("Something went wrong with your first API call.  :(");
        Debug.LogError("Here's some debug information:");
        Debug.LogError(error.GenerateErrorReport());
    }
	
	
	
	
	
	private void OnLoginSuccess3(LoginResult result)
    {
        Debug.Log("Congratulations, you made your first successful API call!");
				PlayFabClientAPI.UpdatePlayerStatistics( new UpdatePlayerStatisticsRequest {
    // request.Statistics is a list, so multiple StatisticUpdate objects can be defined if required.
    Statistics = new List<StatisticUpdate> {
        new StatisticUpdate { StatisticName = "SkinThreeUnlocked", Value = convertedSkinThreeUnlocked },
    }
},
result1 => { Debug.Log("Skin3 saved"); },
error => { Debug.LogError(error.GenerateErrorReport()); });

    }

    private void OnLoginFailure3(PlayFabError error)
    {
        Debug.LogWarning("Something went wrong with your first API call.  :(");
        Debug.LogError("Here's some debug information:");
        Debug.LogError(error.GenerateErrorReport());
    }
	
	
	
	
	void Update ()
	{
	Gems = PlayerPrefs.GetFloat("Gems");
	//SkinOneBought = PlayerPrefs.GetFloat("HasSkinOneUnlocked");
	//SkinTwoBought = PlayerPrefs.GetFloat("SkinTwoUnlocked");
	//SkinThreeBought = PlayerPrefs.GetFloat("SkinThreeUnlocked");
	convertedSkinOneUnlocked = Mathf.FloorToInt(SkinOneBought);
	convertedSkinTwoUnlocked = Mathf.FloorToInt(SkinTwoBought);
	convertedSkinThreeUnlocked = Mathf.FloorToInt(SkinThreeBought);

	}
	
}

