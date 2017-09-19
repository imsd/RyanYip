using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour {

	public GameObject go;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("f")) {
			transform.localScale += new Vector3 (.05f, .05f, .05f);
		}
	}
}
