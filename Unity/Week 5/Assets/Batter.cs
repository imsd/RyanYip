using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batter : MonoBehaviour {

	public float rotatePower;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("Space")) {
			GameObject baseball = Instantiate (goto, transform.ImagePosition, Quaternion.identify);
			baseball.GetComponent<Rigidbody> ().AddForce (Vector3.forward * 1200f);
		}
	}
}
