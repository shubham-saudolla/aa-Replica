/*
Copyright (c) Shubham Saudolla
https://github.com/shubham-saudolla
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
	public static GameControl instance; //using a singleton pattern
	public Rotator rotator; //references in the inspector
	public Spawner spawner;
	private bool _gameEnded = false;
	void Awake ()
	{
		if(instance == null)
		{
			instance = this;
		}
		else if(instance != this)
		{
			Destroy(gameObject);
		}
	}
	
	public void EndGame()
	{
		if(_gameEnded)
		{
			return;
		}

		_gameEnded = true;
		rotator.enabled = false; //disable rotation
		spawner.enabled = false; //disable spawning
		Debug.Log("END GAME");
	}
}
