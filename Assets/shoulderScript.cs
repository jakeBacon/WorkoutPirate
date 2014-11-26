using UnityEngine;
using System.Collections;

public class shoulderScript : MonoBehaviour {

	public GameObject pirate;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = pirate.transform.position;
		transform.rotation = pirate.transform.rotation;

	}
}
