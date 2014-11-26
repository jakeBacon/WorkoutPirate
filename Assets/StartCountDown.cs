using UnityEngine;
using System.Collections;

public class StartCountDown : MonoBehaviour {

	public GUIText startScreen;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if(Time.time < 1) {

			startScreen.text = "3";

		} else if(Time.time < 2) {
			
			startScreen.text = "2";
			
		} else if (Time.time < 3) {
			
			startScreen.text = "1";
			
		} else if (Time.time < 4) {
			
			startScreen.text = "ATTACK!";
			
		} else if (Time.time >= 4) {
			
			startScreen.text = "";
			
		}
	
	}
}
