/*
Copyright (c) Shubham Saudolla
https://github.com/shubham-saudolla
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
	public float speed = 20f;
	public Rigidbody2D rb; //drag in the rigidbody in the inspector

	void Start ()
	{
		
	}
	
	void Update () 
	{
		rb.MovePosition(rb.position + Vector2.up * speed* Time.deltaTime); //using rb.position as iit returns a Vector2. Transform.position returns a Vector3

	}
}
