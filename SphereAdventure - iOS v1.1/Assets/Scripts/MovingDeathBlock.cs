using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDeathBlock : MonoBehaviour {
	
	Vector3 pointA = new Vector3(-3, 0, 0);
    Vector3 pointB = new Vector3(1, 0, 0);
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
		
	}
}
