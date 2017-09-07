using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	//spawn new game object
	public GameObject go;
	//spawn after 1 second
	public float StartAfter = 1f;
	//how often the object is spawned
	public float SpawnFrequency= 0.5f;

	// Use this for initialization
	void Start () {
		//do something every x seconds
		//needs 3 arguments
		//1)what you want to repeat
		//2)after how many seconds do you want to start repeating
		//3)repeat after how many seconds
		InvokeRepeating ("SpawnThing", StartAfter, SpawnFrequency);
	}
	
	// Update is called once per frame
	void SpawnThing () {

		//move spawner
		transform.position = new Vector3(Random.Range(-5,5) , 9, Random.Range(-5,5));

		//to create an object use Instantiate
		//needs 3 arguments
		//1)the object you will create
		//2)where to put it
		//3)what rotation
		Instantiate (go, transform.position, Quaternion.identity);

		//print the location of the spawner
		Debug.Log (transform.position);
	}
}
