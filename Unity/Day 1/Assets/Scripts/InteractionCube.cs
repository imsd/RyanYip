using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCube : MonoBehaviour {

	public Renderer rend;

	// Use this for initialization
	void Start () {
		//at start, get renderer component from object
		//set it to rend
		rend = GetComponent<Renderer> ();
	}

	void OnMouseEnter() {
		rend.material.color = Color.red;
	}

	void OnMouseExit() {
		rend.material.color = Color.blue;
	}

	void OnMouseOver() {
		//Debug.Log ("hi");
		transform.localScale += new Vector3 (.05f, .05f, .05f);
	}
		
}
