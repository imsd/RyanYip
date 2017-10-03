using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public GameObject go;
	public float thrust;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("a")) {
			go.GetComponent<Rigidbody>().AddForce(Vector3.left * thrust);
		}
		if (Input.GetKeyDown ("w")) {
			go.GetComponent<Rigidbody>().AddForce(Vector3.forward * thrust);
		}
		if (Input.GetKeyDown ("s")) {
			go.GetComponent<Rigidbody>().AddForce(Vector3.back * thrust);
		}
		if (Input.GetKeyDown ("d")) {
			go.GetComponent<Rigidbody>().AddForce(Vector3.right * thrust);
		}
	}

}
