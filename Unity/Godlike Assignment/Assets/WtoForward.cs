using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WtoForward : MonoBehaviour {

	public GameObject go;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("w")) {
			//go.GetComponent<Rigidbody>().AddForce(go.transform. * 1f);
			go.transform.position+=Vector3.forward;
		}
	}
}
