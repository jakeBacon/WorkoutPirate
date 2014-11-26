using UnityEngine;
using System.Collections;

public class guiTimerBarPosition : MonoBehaviour {

	public Camera boatGUIcam;
	public firingCannonBalls fire;
	
	// Use this for initialization
	void Start () {
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.localScale = Vector3.zero;
		guiTexture.pixelInset = new Rect (0-145,boatGUIcam.pixelHeight/2*(-1),(fire.firingPower-fire.firePowerRemember)/10,100);

		
	}
}
