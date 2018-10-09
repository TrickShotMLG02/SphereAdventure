using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGem : MonoBehaviour {

	AudioSource CoinPickup;
	
	//public GameObject Gem;
	//public GameObject Coin;
	public float Gems;
	public float TotalGems;
	public float GemsCollected = 0;
	
	// Use this for initialization
	void OnTriggerEnter(Collider target) {
		
		
		if( target.gameObject.tag.Equals("Gem") == true ){
           
		   CoinPickup = GetComponent<AudioSource>();
		   
		   CoinPickup.Play();
		   
		   TotalGems = PlayerPrefs.GetFloat("Gems");
		
		Gems = GemsCollected + 1;
		
		TotalGems = TotalGems + Gems;
		
		PlayerPrefs.SetFloat("Gems", TotalGems);
		Debug.Log(TotalGems);
		   
		   
		   
      }
 }
		
		
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
