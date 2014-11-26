using UnityEngine;
using System.Collections;

public class explosionMessScript : MonoBehaviour {


	public float growth;
	public float timeDecrementor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate (Vector3.up*100*Time.deltaTime);
		transform.localScale += new Vector3 (growth,growth,growth);
		growth = growth - timeDecrementor;
		
		
		Destroy(gameObject, 1.5f);

	}
}
