using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour {

	public string[] Hero;
	public string[] Sidekick;
	public string[] Villian;

	// Use this for initialization
	void Start () {
		
		string randHero = Random.Range (0, Hero.Length);

		Debug.Log ("In a world filled with people who had the power to call themselves hero, " +
		"one girl stood against the tide. " + Hero [randHero] + "had dreamed of becoming a hero. " + 
		"But no one would recognize her because she was like 12, and a girl.");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
