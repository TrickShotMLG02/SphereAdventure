using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour {
    
	
	public float MusicVolume;


	//int scoreCounter;

void Start () {
	
	MusicVolume = PlayerPrefs.GetFloat("Volume");
	GameObject.Find ("Music slider").GetComponent <Slider> ().value = MusicVolume; 
	
	
}


 void Update () {
	
	MusicVolume = GameObject.Find ("Music slider").GetComponent <Slider> ().value;
	
	PlayerPrefs.SetFloat("Volume", MusicVolume);
	
	//scoreCounter.ToString();  // make it a string to output to the Text object

 }
}
