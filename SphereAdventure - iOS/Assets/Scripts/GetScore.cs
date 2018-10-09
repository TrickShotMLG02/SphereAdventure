using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour {

	public float score;
	public Text scoreText;
	

	// Use this for initialization
	void Start () {
		
		scoreText = GetComponent<Text>();  // if you want to reference it by code - tag it if you have several texts
		
	}
	
	// Update is called once per frame
	void Update () {
		
		score = PlayerPrefs.GetFloat("Score");
		scoreText.text = "" + score;
	}
}
