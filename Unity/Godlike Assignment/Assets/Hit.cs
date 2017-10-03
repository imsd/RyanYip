using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision coll) {
		if (coll.gameObject.tag != "Terrain") {
			coll.gameObject.GetComponent<Renderer> ().material.color = Color.blue;
		}

	}
}
