using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterVolume : MonoBehaviour {
    
	
	public float MasterVolumeLevel;


	//int scoreCounter;

void Start () {

	MasterVolumeLevel = PlayerPrefs.GetFloat("MasterVolume");
	GameObject.Find ("Master Volume Slider").GetComponent <Slider> ().value = MasterVolumeLevel;

}


 void Update () {
	
	MasterVolumeLevel = GameObject.Find ("Master Volume Slider").GetComponent <Slider> ().value;
	
	PlayerPrefs.SetFloat("MasterVolume",MasterVolumeLevel);
	
	//scoreCounter.ToString();  // make it a string to output to the Text object

 }
}
