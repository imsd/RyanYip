using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageDisplay : MonoBehaviour {

	public string url = "http://images.earthcam.com/ec_metros/ourcams/fridays.jpg";

	// Use this for initialization
	void Start () {
		GameObject Manager = GameObject.Find("GetPokemon");
		GetPokemon playerScript = GetPokemon.GetComponent<imgUrl>();

		WWW www = new WWW(url);
		yield return www;
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTexture = www.texture;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
