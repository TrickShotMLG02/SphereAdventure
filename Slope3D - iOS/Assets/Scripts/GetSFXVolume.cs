using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSFXVolume : MonoBehaviour {

	AudioSource sfxSource;

	public float SFXVolume;
	public float MasterVolumeLevel;
	

	// Use this for initialization
	void Start () {
		
		sfxSource = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		MasterVolumeLevel = PlayerPrefs.GetFloat("MasterVolume");
		SFXVolume = PlayerPrefs.GetFloat("sfxVolume");
		
		
		sfxSource.volume = SFXVolume * MasterVolumeLevel;
		
	}
}
