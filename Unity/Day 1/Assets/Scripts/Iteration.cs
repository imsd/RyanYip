using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iteration : MonoBehaviour {

	public GameObject go;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			//Debug.Log (i);
			Vector3 myVec = new Vector3(i-4, 2, 0);
			Instantiate (go, myVec, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
