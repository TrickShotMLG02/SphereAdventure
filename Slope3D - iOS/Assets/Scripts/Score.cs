using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    
	
	public float score;

	
	public Text scoreText;  // public if you want to drag your text object in there manually


	//int scoreCounter;

void Start () {

	scoreText = GetComponent<Text>();  // if you want to reference it by code - tag it if you have several texts
}


 void Update () {
	
	score = score + 1;
	
    scoreText.text = "" + score;
	
	PlayerPrefs.SetFloat("Score", score);
	
	//scoreCounter.ToString();  // make it a string to output to the Text object

 }
}
