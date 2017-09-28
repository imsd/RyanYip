using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TtoDestroy : MonoBehaviour {

	public GameObject go1;
	public GameObject go2;
	public GameObject go3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("t")) {
			Destroy (go1);
			Destroy (go2);
			Destroy (go3);
		}
	}
}
