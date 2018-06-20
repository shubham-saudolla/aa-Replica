﻿/*
Copyright (c) Shubham Saudolla
https://github.com/shubham-saudolla
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
	public Sound[] sounds; //array that holds all the sounds
	public static AudioManager instance; //for a singleton pattern

	void Awake()
	{
		DontDestroyOnLoad(gameObject);

		if(instance == null)
		{
			instance = this;
		}
		else if(instance != this)
		{
			Destroy(gameObject);
		}
	}

	void Start ()
	{
		foreach(Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.volume = s.volume;
			s.source.loop = s.loop;
		}
	}
	
	public void Play(string name)
	{
		Sound s = Array.Find(sounds, sounds => sounds.name == name);
		if(s == null)
		{
			Debug.LogWarning("Sound " + name + "not found.");
		}
		s.source.Play();
	}
}