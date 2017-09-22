using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtoSpawn : MonoBehaviour {

	public GameObject go;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("a")) {
			Instantiate (go, transform.position, Quaternion.identity);
		}
	}
}
