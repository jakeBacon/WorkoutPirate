using UnityEngine;
using System.Collections;

public class cameraPositioning : MonoBehaviour {

	public GameObject boat;
	private float boatRotX;
	private float boatRotY;
	private float boatRotZ;
	private float boatRotW;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(boat){
		boatRotX = boat.transform.rotation.x*0;
		boatRotY = boat.transform.rotation.y;
		boatRotZ = boat.transform.rotation.z*0;
		boatRotW = boat.transform.rotation.w;

		transform.position = boat.transform.position;
		transform.rotation = new Quaternion(boatRotX, boatRotY, boatRotZ,boatRotW);

		}
	}
}
