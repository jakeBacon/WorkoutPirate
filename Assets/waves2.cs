using UnityEngine;
using System.Collections;

public class waves2 : MonoBehaviour {

	private float x;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Color color;
		color = renderer.material.color;
		color.a = 0.1f;
		renderer.material.color = color;

		x = x + 0.02f*Time.deltaTime;
		transform.rotation = new Quaternion(transform.rotation.x, Mathf.Sin (x)/120,transform.rotation.z, transform.rotation.w);

	}
}
