using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPokemon : MonoBehaviour {

	private string baseUrl = "https://pokeapi.co/api/v2/pokemon/";
	public string pokemon = "bulbasaur";
	public string imgUrl = "";


	public int hp;
	public int att;
	public int def;
	public int satt;
	public int sdef;
	public int spd;
	public string tp;
	public string tp1;


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
		spd = baseSpeed;


		JSONObject specialdefenseDetails = statsDetails[1];
		JSONObject baseSpecialDefense = specialdefenseDetails["base_stat"];
		Debug.Log (baseSpecialDefense);
		sdef = baseSpecialDefense;

		JSONObject specialattackDetails = statsDetails[2];
		JSONObject baseSpecialAttack = specialattackDetails["base_stat"];
		Debug.Log (baseSpecialAttack);
		satt = baseSpecialAttack;

		JSONObject defenseDetails = statsDetails[3];
		JSONObject baseDefense = defenseDetails["base_stat"];
		Debug.Log (baseDefense);
		def = baseDefense;

		JSONObject attackDetails = statsDetails[4];
		JSONObject baseAttack = attackDetails["base_stat"];
		Debug.Log (baseAttack);
		att = baseAttack;

		JSONObject hpDetails = statsDetails[5];
		JSONObject baseHp = hpDetails["base_stat"];
		Debug.Log (baseHp);
		hp = baseHp;

		// get the sprite
		JSONObject spriteDetails = tempData["sprites"];
		JSONObject image = spriteDetails["front_default"];
		Debug.Log (image);
		// for some reason, backslashes are getting introduced, probably in the string
		// conversion, so we have to remove them here...
		string imageURL = image.ToString ().Replace(@"\", "");

		// AND its putting quotes in front and back, so remove those...

		imageURL = imageURL.Replace ("\"", "");

		// ... finally, time for the image! we have a clean URL
			// Start a download of the given URL
			WWW imageWWW = new WWW(imageURL);

		// Wait for download to complete
		yield return imageWWW;

		// assign texture
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTexture = imageWWW.texture;



		JSONObject typeDetails = tempData["types"];
		JSONObject type = typeDetails[0];
		JSONObject baseType = type["type"];
		JSONObject typeName = baseType["name"];
		Debug.Log (typeName);
		tp = typeName;

		if (typeDetails [1] != null)
		{
			JSONObject atype = typeDetails [1];
			JSONObject abaseType = atype ["type"];
			JSONObject atypeName = abaseType ["name"];
			Debug.Log (atypeName);
			tp1 = atypeName;
		}
	}
}
