using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFX_Volume : MonoBehaviour {
    
	
	public float getsfxVolume;


	//int scoreCounter;

void Start () {
	
	getsfxVolume = PlayerPrefs.GetFloat("sfxVolume");
	GameObject.Find ("SFX Slider").GetComponent <Slider> ().value = getsfxVolume;


}


 void Update () {
	
	getsfxVolume = GameObject.Find ("SFX Slider").GetComponent <Slider> ().value;
	
	PlayerPrefs.SetFloat("sfxVolume", getsfxVolume);
	
	//scoreCounter.ToString();  // make it a string to output to the Text object

 }
}
