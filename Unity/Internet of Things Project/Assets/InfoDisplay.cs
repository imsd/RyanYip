using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoDisplay : MonoBehaviour {

	public GameObject Here;
	public string name;
	public int hp;
	public int att;
	public int def;
	public int satt;
	public int sdef;
	public int spd;
	public string type;
	public string type1;

	public TextMesh derp;


	// Use this for initialization
	void Start () {
		GameObject.GetComponent (GetPokemon);
		this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		name = GetPokemon.pokemon;
		hp = GetPokemon.hp;
		att = GetPokemon.att;
		def = GetPokemon.def;
		satt = GetPokemon.satt;
		sdef = GetPokemon.sdef;
		spd = GetPokemon.spd;
		type = GetPokemon.tp;
		if (GetPokemon.tp1 != null)
		{
			type1 = GetPokemon.tp1;
		}

		derp.text = name;
	}
}
