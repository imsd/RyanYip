using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject go;
	public float StartAfter = 1f;
	public float SpawnFrequency= 0.5f;

	void Start () {
		InvokeRepeating ("SpawnThing", StartAfter, SpawnFrequency);
	}
	
	// Update is called once per frame
	void SpawnThing () {
		transform.position = new Vector3(-19 , 10, Random.Range(-15,15));
		Instantiate (go, transform.position, Quaternion.identity);
	}
}
