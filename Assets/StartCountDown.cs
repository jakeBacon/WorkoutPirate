using UnityEngine;
using System.Collections;

public class StartCountDown : MonoBehaviour {

	public GUIText startScreen;
	private float counter = 0;

	// Use this for initialization
	void Start () {
		counter = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

		if(Time.time < counter) {

			startScreen.text = "3";

		}
		if (Time.time - counter > 1) {
			
			startScreen.text = "2";
			
		}
		if (Time.time - counter > 2) {
			
			startScreen.text = "1";
			
		}
		if (Time.time - counter > 3) {
			
			startScreen.text = "ATTACK!";
			
		}
		if (Time.time - counter > 4) {
			
			startScreen.text = "";
			
		}
			
	}
}
