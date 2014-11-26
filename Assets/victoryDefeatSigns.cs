using UnityEngine;
using System.Collections;

public class victoryDefeatSigns : MonoBehaviour {

	public GUITexture defeat;
	public GUITexture victory;
	public GameObject boat1;
	public GameObject boat2;
	public bool GameInProgress;
	public Camera sharedCam;
	public float theTimeToNextScene;

	// Use this for initialization
	void Start () {
	
		GameInProgress = true;

	}
	
	// Update is called once per frame
	void Update () {
	
		if(boat1 == null && GameInProgress==true){
			GUITexture victorySign;
			victorySign = Instantiate(victory, Vector3.zero, Quaternion.identity) as GUITexture;
			victorySign.pixelInset = new Rect(sharedCam.pixelWidth/2-100,sharedCam.pixelHeight/4*3-100,200,200);

			GUITexture defeatSign;
			defeatSign = Instantiate(defeat, Vector3.zero, Quaternion.identity) as GUITexture;
			defeatSign.pixelInset = new Rect(sharedCam.pixelWidth/2-100,sharedCam.pixelHeight/4-100,200,200);

			GameInProgress=false;
			theTimeToNextScene=Time.time;

		}

		if(boat2 == null && GameInProgress==true){
			GUITexture victorySign;
			victorySign = Instantiate(victory, Vector3.zero, Quaternion.identity) as GUITexture;
			victorySign.pixelInset = new Rect(sharedCam.pixelWidth/2-100,sharedCam.pixelHeight/4-100,200,200);
			
			GUITexture defeatSign;
			defeatSign = Instantiate(defeat, Vector3.zero, Quaternion.identity) as GUITexture;
			defeatSign.pixelInset = new Rect(sharedCam.pixelWidth/2-100,sharedCam.pixelHeight/4*3-100,200,200);
			
			GameInProgress=false;
			theTimeToNextScene=Time.time;

		}

		if(GameInProgress==false && theTimeToNextScene+3<Time.time){
			Application.LoadLevel("menuScreen");
			
		}

	}
}
