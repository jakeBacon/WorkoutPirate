using UnityEngine;
using System.Collections;

public class explosionScript : MonoBehaviour {

	public float growth;
	public float timeDecrementor;
	public float decreaser;
	//public audioController sound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//sound.playAudio (3);
		transform.localScale += new Vector3 (growth,growth,growth);
		growth = growth - timeDecrementor;


		Destroy(gameObject, 1.5f);
		//sound.playAudio(0);
	}
}
