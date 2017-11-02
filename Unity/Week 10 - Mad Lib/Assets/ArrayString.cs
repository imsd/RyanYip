using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayString : MonoBehaviour {

	public string[] names;
	public string[] places;

	// Use this for initialization
	void Start () {
//		for (int c = 0; c < names.Length; c++) {
//			Debug.Log (names [c]);
//		}

		int randNoun = Random.Range (0, names.Length);
		int randPlace = Random.Range (0, places.Length);

		string line1 = "One day, " + names [randNoun] + " went to " + places[randPlace] + ".";


		Debug.Log (line1);
	}
	
	// Update is called once per frame
	void Update () {
//		int rando = Random.Range (0, names.Length);
//		Debug.Log (names [rando]);
	}
}
