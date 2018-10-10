using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) {
	
	Time.timeScale = 1.25f;
	PlayerPrefs.SetFloat("GameSpeed", 1.25f);
	Destroy(other.gameObject);
	SceneManager.LoadScene("DeathScreen");
	
	}
	
}
