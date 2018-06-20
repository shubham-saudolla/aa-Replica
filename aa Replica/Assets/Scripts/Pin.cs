﻿/*
Copyright (c) Shubham Saudolla
https://github.com/shubham-saudolla
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
	public float speed = 20f;
	private bool isPinned = false;
	public Rigidbody2D rb; //drag in the rigidbody in the inspector
	
	void Update () 
	{
		if(!isPinned)
			rb.MovePosition(rb.position + Vector2.up * speed* Time.deltaTime); //using rb.position as iit returns a Vector2. Transform.position returns a Vector3
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag == "Rotator")
		{
			transform.SetParent(col.transform); //parenting the pin to the rotator
			isPinned = true;
		}
	}
}
