﻿using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;
	public static bool playMusic = true;
	
	// Use this for initialization
	void Start () {
		//if (instance != null) {
		//	Destroy (gameObject);
		//	print ("Duplicate music player self-destructing!");
		//} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		//}
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!playMusic) {
			GameObject.Destroy(gameObject);
		}
	}
}
