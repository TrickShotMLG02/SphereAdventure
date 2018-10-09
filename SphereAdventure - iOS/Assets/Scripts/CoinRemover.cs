using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRemover : MonoBehaviour {
	
	public GameObject Gem;
	
	void OnTriggerEnter(Collider other)
	{	
		Gem.SetActive(false);
	}
}