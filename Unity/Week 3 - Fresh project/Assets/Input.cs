using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour {

	public float multiplier = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float rotationX = Input.GetAxis("Horizontal") * multiplier;
		float rotationY = Input.GetAxis("Vertical") * multiplier;
		//Debug.Log (rotation);
		Vector3 v3 = new Vector3 (rotationX, rotationY, 0);
		transform.Rotate (v3);
	}
}
