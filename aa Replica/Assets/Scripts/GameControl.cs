/*
Copyright (c) Shubham Saudolla
https://github.com/shubham-saudolla
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
	public static GameControl instance; //using a singleton pattern
	public Rotator rotator; //references in the inspector
	public Spawner spawner;
	public Animator animator; //a reference to the animator is required to play an animation
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

		animator.SetTrigger("EndGame");

		Debug.Log("END GAME");
	}

	public void RestartLevel() //called at the end of the EndGame animation by the animator
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
