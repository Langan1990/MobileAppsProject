﻿using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
    //variables
	public GameObject[] obj;
	public float SpawnMin = 1f;
	public float SpawnMax = 2f;


	// Use this for initialization
	void Start () {
		Spawn ();   // calls the spawn method
	
	}
	
	void Spawn()
	{
		Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
		Invoke ("Spawn", Random.Range (SpawnMin, SpawnMax)); // invokes itself between the 2 defined times
	}
}
