using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAcceleration : MonoBehaviour {

	public float acceleration;
    public Rigidbody rb;
    
	
	void Start() {
        rb = GetComponent<Rigidbody>();
		acceleration = acceleration + 1f;
		
    }
	
	
    void Update() {
		acceleration = acceleration + 0.01f;
        rb.AddForce(transform.forward * acceleration);
    }
	
}
