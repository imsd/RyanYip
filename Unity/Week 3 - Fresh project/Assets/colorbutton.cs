﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorbutton : MonoBehaviour {

	public Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("s")) {
			rend.material.color = Color.blue;
		}

	}
}
