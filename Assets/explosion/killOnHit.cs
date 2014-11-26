using UnityEngine;
using System.Collections;

public class killOnHit : MonoBehaviour {

	private bool sinking=false;
	public GameObject ship;
	//public audioController sound;

	//public GameObject explosion;

	void Update(){


		if(sinking==true){
			ship.transform.position=ship.transform.position+ new Vector3(0,-0.1f,0);
			//GameObject boom;
			//boom = Instantiate(explosion, ship.transform.position, ship.transform.rotation) as GameObject;


		}

		}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag== "boat"){
			sink(col.gameObject);
			sinking=true;
			//sound.playAudio(2);
			Destroy(col.gameObject, 3.5f);

		}

	}

	void sink(GameObject boat){
		ship = boat;
	}

}
