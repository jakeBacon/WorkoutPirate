using UnityEngine;
using System.Collections;

public class trackerStart : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetButtonDown("right")){

			Application.LoadLevel("PirateScene");

		}

	}
}
