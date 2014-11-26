using UnityEngine;
using System.Collections;

public class cannonFireGUIbehaviour : MonoBehaviour {

	public firingCannonBalls fire;
	public GUIElement firingTimerFrame;
	public Camera GuiCamera;
	private Texture frame;

	// Use this for initialization
	void Start () {
		frame = firingTimerFrame.guiTexture.texture;
		firingTimerFrame.guiTexture.texture =null;
	}
	
	// Update is called once per frame
	void OnGUI () {
	
		if(fire.firing==true){
			firingTimerFrame.guiTexture.texture = frame;
		} else {
			firingTimerFrame.guiTexture.texture =null;
		}

	}
}
