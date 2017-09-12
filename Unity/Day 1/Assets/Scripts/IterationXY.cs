using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IterationXY : MonoBehaviour {

	public GameObject go;

	// Use this for initialization
	void Start () {
		for (int x = 0; x < 10; x++) {
			for (int z = 0; z < 10; z++) {
				for (int y = 0; y < 10; y++) {
					Vector3 myVec = new Vector3(x, y, z);
					Instantiate (go, myVec, Quaternion.identity);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
