using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject Slope;
	public GameObject Slope2;
	public GameObject Slope3;
	
	public float Skinnumber;
	
	public Vector3 offset;
	
	// Use this for initialization
	void Start () {
		Skinnumber = PlayerPrefs.GetFloat("SkinSelected");
			offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
		
		if(Skinnumber == 1)
		{
			transform.position = Slope.transform.position + offset;
		}	
		
		if(Skinnumber == 2)
		{
			transform.position = Slope2.transform.position + offset;
		}
			
		if(Skinnumber == 3)
		{
			transform.position = Slope3.transform.position + offset;
		}
		
		
		
		
	}
}
