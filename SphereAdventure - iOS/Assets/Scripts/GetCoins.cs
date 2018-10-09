using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCoins : MonoBehaviour {

	public float GemCount;
	public Text GemText;
	

	// Use this for initialization
	void Start () {
		
		GemText = GetComponent<Text>();  // if you want to reference it by code - tag it if you have several texts
		
	}
	
	// Update is called once per frame
	void Update () {
		
		GemCount = PlayerPrefs.GetFloat("Gems");
		GemText.text = "" + GemCount;
	}
}
