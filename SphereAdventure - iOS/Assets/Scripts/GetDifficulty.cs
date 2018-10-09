using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDifficulty : MonoBehaviour {

	public float DifficultyLvl;
	public GameObject Hard;
	public GameObject Booster;
	

	// Use this for initialization
	void Start () {
		DifficultyLvl = PlayerPrefs.GetFloat("Difficulty");
		 if(DifficultyLvl == 1)
        {
			Hard.SetActive(false);
			Booster.SetActive(true);
        }
		else if(DifficultyLvl == 2)
		{
			Hard.SetActive(true);
			Booster.SetActive(false);
		}
		//else
	//	{
	//		Booster.SetActive(false);
	//		Hard.SetActive(false);
		//}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
}
