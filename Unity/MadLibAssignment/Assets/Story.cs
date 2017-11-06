using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour {

	public string[] Hero;
	public string[] Mon;
	public string[] Corp;
	public string[] Item;

	public Renderer rend;

	// Use this for initialization
	void Start () {

		rend = GetComponent<Renderer> ();

		int randHero = Random.Range (0, Hero.Length);
		int randCorp = Random.Range (0, Corp.Length);
		int randItem = Random.Range (0, Item.Length);
		int randMon = Random.Range (0, Mon.Length);

		Debug.Log ("One day the " + Corp [randCorp] + " decided to fund an epic quest. " + 
			"The quest would need someone to fetch a " +  Item [randItem] + " and use it to save the world from the " +
			Mon [randMon] + ". Then " + Hero [randHero] + " appeared to claim the " + randItem +
		" and went on to save the world.");
		if (randHero == 0) {
			rend.material.color = Color.blue;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
