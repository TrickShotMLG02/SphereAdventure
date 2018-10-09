using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
	
	Time.timeScale += 1f;
	
	}
}
