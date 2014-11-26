using UnityEngine;
using System.Collections;

public class cannonBallBehavior : MonoBehaviour {

	public movement muzzle;
	public GameObject explosion;

	// Use this for initialization
	void Start () {
	
		//rigidbody.AddForce(muzzle.transform.forward*5000);

	}
	

	void OnCollisionEnter(){
		GameObject ball;
		ball=Instantiate (explosion, transform.position, transform.rotation) as GameObject;
		Destroy (gameObject);
	}
}
