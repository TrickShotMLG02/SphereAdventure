using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetVolume : MonoBehaviour {

	AudioSource MusicSource;

	public float MusicVolume;
	public float MasterVolumeLevel;
	

	// Use this for initialization
	void Start () {
		
		MusicSource = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		MasterVolumeLevel = PlayerPrefs.GetFloat("MasterVolume");
		MusicVolume = PlayerPrefs.GetFloat("Volume");
		
		
		MusicSource.volume = MusicVolume * MasterVolumeLevel;
		
	}
}
