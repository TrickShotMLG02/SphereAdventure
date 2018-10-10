using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{

	public GameObject[] tilePrefabs;
	private Transform playerTransform;
	private float SpawnZ = 0.0f;
	private float SpawnY = 3.09f;
	private float SpawnX = -4.2f;
	private float height = 2.8f;
	private float TileLength = 15.7f;
	private int amnTilesOnScreen = 7;
	
	private int GeneratorNumber = 0;
	
	private int lastPrefabIndex = 0;
	
	
	// Use this for initialization
	private void Start () {
	
	//playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
	
	}

	
	
	// Update is called once per frame
	private void Update () {				

		GeneratorNumber = GeneratorNumber + 1;
	
	 if(GeneratorNumber == 10)
        {
            SpawnTile ();
			GeneratorNumber = GeneratorNumber - 10;
        }

	
	}
	
	private void SpawnTile(int prefabIndex = -1)
	{
		GameObject go;
		go = Instantiate (tilePrefabs [RandomPrefabIndex()]) as GameObject;
		go.transform.SetParent (transform);
		go.transform.position = new Vector3(SpawnX, SpawnY, SpawnZ);
		SpawnZ += TileLength;
		SpawnY = SpawnY - height;
	}
	
	private int RandomPrefabIndex () {
		
		if (tilePrefabs.Length <= 1)
			return 0;
		
		int randomIndex = lastPrefabIndex;
		while (randomIndex == lastPrefabIndex)
		{
			randomIndex = Random.Range(0,tilePrefabs.Length);
		}
		
		lastPrefabIndex = randomIndex;
		return randomIndex;
		
	}
	
}
