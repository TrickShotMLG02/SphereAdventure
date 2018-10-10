using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    
	
	public float Highscore;
	public float score;
	
	
	
	public Text scoreText;  // public if you want to drag your text object in there manually


	//int scoreCounter;

void Start () {

	scoreText = GetComponent<Text>();  // if you want to reference it by code - tag it if you have several texts
}


 void Update () {
	 
	score = PlayerPrefs.GetFloat("Score");
	Highscore = PlayerPrefs.GetFloat("HighScore");
	
	if (score > Highscore)
		{
			PlayerPrefs.SetFloat("HighScore", score);
		}
		else	
		{
			
		}
	//PlayerPrefs.SetFloat("HighScore", Highscore);
	
	//scoreCounter.ToString();  // make it a string to output to the Text object

 }
}
