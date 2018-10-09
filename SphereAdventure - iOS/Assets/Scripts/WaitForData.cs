using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForData : MonoBehaviour {

	public GameObject Button;


	// Use this for initialization
	void Start () {
		
		Button.SetActive(false);
		
		StartCoroutine(Example());
	}
	
	IEnumerator Example()
    {
        yield return new WaitForSeconds(5);
		Button.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
