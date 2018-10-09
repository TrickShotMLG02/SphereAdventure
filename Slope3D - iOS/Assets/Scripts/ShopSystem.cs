using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopSystem : MonoBehaviour {
	
	public float Gems;
	
	public float SkinOnePrice;
	public float SkinOneBought;
	public bool SkinOneSelected;
	
	public float SkinTwoPrice;
	public float SkinTwoBought;
	public bool SkinTwoSelected;
	
	public float SkinThreePrice;
	public float SkinThreeBought;
	public bool SkinThreeSelected;
	
	public Button SkinOneButton;
	public Button SkinTwoButton;
	public Button SkinThreeButton;
	
	public bool btnOneIsPressed;
	public bool btnTwoIsPressed;
	public bool btnThreeIsPressed;
	
	public Text SkinOne;
	public Text SkinTwo;
	public Text SkinThree;
	
	// Use this for initialization
	void Start () {
		
		SkinOneBought = PlayerPrefs.GetFloat("HasSkinOneUnlocked");
		SkinTwoBought = PlayerPrefs.GetFloat("SkinTwoUnlocked");
		SkinThreeBought = PlayerPrefs.GetFloat("SkinThreeUnlocked");
		
		Button btnOne = SkinOneButton.GetComponent<Button>();
		Button btnTwo = SkinTwoButton.GetComponent<Button>();
		Button btnThree = SkinThreeButton.GetComponent<Button>();
		
		Gems = PlayerPrefs.GetFloat("Gems");
		
		
		btnOne.onClick.AddListener(SkinOneBuy);
		btnTwo.onClick.AddListener(SkinTwoBuy);
		btnThree.onClick.AddListener(SkinThreeBuy);
		
		if(SkinOneBought == 1)
		{
			SkinOne.text = "Select";
		}	
			else if(SkinTwoBought == 1)
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
			SkinOneBought = 1f;
			PlayerPrefs.SetFloat("HasSkinOneUnlocked", 1);
			SkinOneSelected = true;
			PlayerPrefs.SetFloat("SkinSelected", 1);
			
			
			
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
			SkinTwoBought = 1f;
			PlayerPrefs.SetFloat("SkinTwoUnlocked", 1);
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
			PlayerPrefs.SetFloat("SkinThreeUnlocked", 1);
			PlayerPrefs.SetFloat("SkinThreeUnlocked", 1);
			SkinThreeBought = 1;
			SkinThreeSelected = true;
			SkinOneSelected = false;
			SkinTwoSelected = false;
			SkinThree.text = "Selected";
			PlayerPrefs.SetFloat("SkinSelected", 3);
			
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
	
	void Update ()
	{
	Gems = PlayerPrefs.GetFloat("Gems");
	//SkinOneBought = PlayerPrefs.GetFloat("HasSkinOneUnlocked");
	//SkinTwoBought = PlayerPrefs.GetFloat("SkinTwoUnlocked");
	//SkinThreeBought = PlayerPrefs.GetFloat("SkinThreeUnlocked");

	}
	
}

