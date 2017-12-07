using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPokemon : MonoBehaviour {

	private string baseUrl = "https://pokeapi.co/api/v2/pokemon/";
	public string pokemon = "bulbasaur";
	public string imgUrl = "";

	IEnumerator Start() {

		// fetch the actual info, like you would from a browser
		WWW www = new WWW(baseUrl + pokemon);

		// yield return waits for the download to complete before proceeding
		// but since this is in IEnumerator it wont stall the program outright
		yield return www;

		// use a JSON Object to store the info temporarily
		// this makes it easy to access the data struture
		JSONObject tempData = new JSONObject (www.text);

		// this particular API stores all the data under the header
		// "consolidated_weather" so first get in there
		JSONObject statsDetails = tempData["stats"];

		// log it just to see whats up
		//Debug.Log (statsDetails.ToString());

		// to get more specific
		JSONObject speedDetails = statsDetails[0];
		//Debug.Log (speedDetails);
		// to get even more specific
		JSONObject baseSpeed = speedDetails["base_stat"];
		Debug.Log (baseSpeed);

		JSONObject specialdefenseDetails = statsDetails[1];
		JSONObject baseSpecialDefense = specialdefenseDetails["base_stat"];
		Debug.Log (baseSpecialDefense);

		JSONObject specialattackDetails = statsDetails[2];
		JSONObject baseSpecialAttack = specialattackDetails["base_stat"];
		Debug.Log (baseSpecialAttack);

		JSONObject defenseDetails = statsDetails[3];
		JSONObject baseDefense = defenseDetails["base_stat"];
		Debug.Log (baseDefense);

		JSONObject attackDetails = statsDetails[4];
		JSONObject baseAttack = attackDetails["base_stat"];
		Debug.Log (baseAttack);

		JSONObject hpDetails = statsDetails[5];
		JSONObject baseHp = hpDetails["base_stat"];
		Debug.Log (baseHp);

		// get the sprite
		JSONObject spriteDetails = tempData["sprites"];
		JSONObject image = spriteDetails["front_default"];
		Debug.Log (image);
		imgUrl = image;
	}
}
