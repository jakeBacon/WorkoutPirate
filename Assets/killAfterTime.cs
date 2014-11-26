using UnityEngine;
using System.Collections;

public class killAfterTime : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Destroy (gameObject, 30f);

	}
}
