/*
Copyright (c) Shubham Saudolla
https://github.com/shubham-saudolla
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject pinPrefab;

	void Start ()
	{
		
	}
	
	void Update () 
	{
		if(Input.GetMouseButtonDown(0)) //spacebar or left mouse click
		{
			SpawnPin();
		}
	}

	void SpawnPin()
	{
		Instantiate(pinPrefab, transform.position, transform.rotation); //spawn at the PinSpawnPoint with it's position and rotation
	}
}
