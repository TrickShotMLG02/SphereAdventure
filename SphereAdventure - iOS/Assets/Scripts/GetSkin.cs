using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSkin : MonoBehaviour {

	public float SkinNumber;
	public GameObject Skin01;
	public GameObject Skin02;
	public GameObject Skin03;	

	// Use this for initialization
	void Start () {
		SkinNumber = PlayerPrefs.GetFloat("SkinSelected");
		 if(SkinNumber == 1)
        {
			Skin01.SetActive(true);
			Skin02.SetActive(false);
			Skin03.SetActive(false);
        }
		else if(SkinNumber == 2)
		{
			Skin01.SetActive(false);
			Skin02.SetActive(true);
			Skin03.SetActive(false);
		}
		else if(SkinNumber == 3)
		{
			Skin01.SetActive(false);
			Skin02.SetActive(false);
			Skin03.SetActive(true);
		}
		else
		{
			Skin01.SetActive(true);
			Skin02.SetActive(false);
			Skin03.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
	}
}
