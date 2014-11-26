using UnityEngine;
using System.Collections;

public class boatRocking : MonoBehaviour {

	private float angle;
	private float theTime;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate (Vector3.forward,angle);

		theTime = Time.time;
		angle = Mathf.Sin (theTime) / 10;


	}
}
