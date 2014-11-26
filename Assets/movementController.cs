using UnityEngine;
using System.Collections;

public class movementController : MonoBehaviour {

	public arduinoTracker tracker;
	public bool move = false;
	private bool moveEnable = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(tracker.maxValue-10-tracker.currentValue>0 ){
			move=true;
			//moveEnable=false;
		}

		if(tracker.minValue+10-tracker.currentValue<0){
			moveEnable=true;
			move=false;
		}

		if (move==true) {
			print (tracker.maxValue-10-tracker.currentValue + "meaning i moved");
				} else {
			print(tracker.minValue+10-tracker.currentValue +"i am not moving");
				}

		//move = false;

	}
}
