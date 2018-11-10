using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRestartOption : MonoBehaviour {

    public string SceneName;

	// Use this for initialization
	void Start () {

        PlayerPrefs.SetString("LevelName", SceneName);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
