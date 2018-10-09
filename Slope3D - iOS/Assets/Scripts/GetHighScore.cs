using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHighScore : MonoBehaviour {

	public float Highscore;
	
	public Text HighscoreText;	
	//public Text congratsText;	

	// Use this for initialization
	void Start () {
		
		HighscoreText = GetComponent<Text>();
		//congratsText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
		Highscore = PlayerPrefs.GetFloat("HighScore");
		
			HighscoreText.text = "" + Highscore;
			//congratsText.text = "New Highscore";

	}
}
