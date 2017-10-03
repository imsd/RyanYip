using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	
	public GameObject go;
	public float thrust;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			go.GetComponent<Rigidbody>().AddForce(Vector3.up * thrust);
		}
	}
}
