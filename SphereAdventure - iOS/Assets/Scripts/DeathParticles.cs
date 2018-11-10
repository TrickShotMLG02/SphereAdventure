﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathParticles : MonoBehaviour {
	AudioSource sfxExp;
	
	public string SceneName;
	
	void OnTriggerEnter(Collider Player) {
	
	var exp = GetComponent<ParticleSystem>();
	sfxExp = GetComponent<AudioSource>();
	
	sfxExp.Play();
	exp.Play();
	
	Time.timeScale = 1.25f;
	PlayerPrefs.SetFloat("GameSpeed", 1.25f);
	Destroy(Player.gameObject);
	StartCoroutine(Example());

	
	}
	
	 IEnumerator Example()
    {
        yield return new WaitForSeconds(1);
		SceneManager.LoadScene(SceneName);
    }

	
	
}
