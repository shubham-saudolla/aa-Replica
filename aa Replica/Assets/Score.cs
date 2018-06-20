/*
Copyright (c) Shubham Saudolla
https://github.com/shubham-saudolla
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public static int pinCount = 0;
	public static bool canScore = true;
	public Text scoreText;

	void Start ()
	{
		pinCount = 0; //static variables need to be reset when a scene is reloaded
		canScore = true;
	}
	
	void Update () 
	{
		scoreText.text = pinCount.ToString();
	}
}
