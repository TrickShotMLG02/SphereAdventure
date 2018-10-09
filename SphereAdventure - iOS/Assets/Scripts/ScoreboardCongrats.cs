using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreboardCongrats : MonoBehaviour {

	public float Highscore;
	public float score;
	
	//public Text HighscoreText;	
	public Text congratsText;	

	// Use this for initialization
	void Start () {
		
		congratsText = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Highscore = PlayerPrefs.GetFloat("HighScore");
		score = PlayerPrefs.GetFloat("Score");
		
		if (Highscore == score)
		{
			congratsText.text = "New Highscore";
		}
		else
		{
			congratsText.text = "";
		}
		
	}
}
