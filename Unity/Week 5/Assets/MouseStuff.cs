using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseStuff : MonoBehaviour {

	public float forcePower = 1000f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown() {
		Vector3 forceDirection = Vector3.forward * forcePower;
		GetComponent<Rigidbody> ().AddForce (forceDirection);
	}
}
