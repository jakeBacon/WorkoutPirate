using UnityEngine;
using System.Collections;

public class explosionScript : MonoBehaviour {

	public float growth;
	public float timeDecrementor;
	public GameObject explosionMess;
	public GameObject explosionSmoke;


	public GameObject smoke;
	public GameObject mess;


	// Use this for initialization
	void Start () {



		mess = Instantiate (explosionMess,transform.position,transform.rotation) as GameObject;

		smoke = Instantiate (explosionSmoke, new Vector3(transform.position.x,transform.position.y+50,transform.position.z),Quaternion.Euler(0,0,0)) as GameObject;

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
