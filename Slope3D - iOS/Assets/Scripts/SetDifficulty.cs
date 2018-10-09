using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetDifficulty : MonoBehaviour {
    
	
	public float DifficultyLvl;


	//int scoreCounter;

void Start () {
	
	DifficultyLvl = PlayerPrefs.GetFloat("Difficulty");
	GameObject.Find ("Dificulty Slider").GetComponent <Slider> ().value = DifficultyLvl;
	
	
}


 void Update () {
	
	DifficultyLvl = GameObject.Find ("Dificulty Slider").GetComponent <Slider> ().value;
	
	PlayerPrefs.SetFloat("Difficulty",DifficultyLvl);
	
	//scoreCounter.ToString();  // make it a string to output to the Text object

 }
}
