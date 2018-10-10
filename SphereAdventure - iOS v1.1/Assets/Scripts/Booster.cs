using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Booster : MonoBehaviour {

	public float TimeScale;


	void OnTriggerEnter(Collider other) {
	
	TimeScale = PlayerPrefs.GetFloat("GameSpeed");
	
	Time.timeScale += 1f;
	TimeScale = TimeScale + 1;
	
	PlayerPrefs.SetFloat("GameSpeed", TimeScale);
	
	}
}
