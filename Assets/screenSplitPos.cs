using UnityEngine;
using System.Collections;

public class screenSplitPos : MonoBehaviour {

	public Camera sharedGUIcam;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		guiTexture.pixelInset = new Rect (-(sharedGUIcam.pixelWidth/2),-40,sharedGUIcam.pixelWidth, 100);

	}
}
