using UnityEngine;
using System.Collections;

public class timerFramePositioning : MonoBehaviour {

	public Camera boatGUIcam;

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
	
		transform.localScale = Vector3.zero;
		guiTexture.pixelInset = new Rect (0-150,boatGUIcam.pixelHeight/2*(-1),300,100);
			

	}
}
