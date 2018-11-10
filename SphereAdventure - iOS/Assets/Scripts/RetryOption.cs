using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryOption : MonoBehaviour
{
	public string SceneName;
	public Text LevelNameLabel;
	
	private void Start () {
	
	LevelNameLabel = GetComponent<Text>();
	SceneName = PlayerPrefs.GetString("LevelName");
	LevelNameLabel.text = "" + SceneName;
	
}
	public void NextScene()

    {
        SceneManager.LoadScene(SceneName);
    }
	
}
