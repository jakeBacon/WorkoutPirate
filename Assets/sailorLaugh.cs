using UnityEngine;
using System.Collections;

public class sailorLaugh : MonoBehaviour {

	public victoryDefeatSigns victoryLaugh;
	public GameObject sound;
	public AudioClip laugh;
	public AudioSource sailorHoHo;
	private bool alreadyLaughing;

	// Use this for initialization
	void Start () {
	
		alreadyLaughing=false;

	}
	
	// Update is called once per frame
	void Update () {
		if (!victoryLaugh.GameInProgress && alreadyLaughing==false) {
			AudioSource victorySource;
			victorySource = Instantiate(sailorHoHo, sound.transform.position, sound.transform.rotation) as AudioSource;
			victorySource.audio.clip = laugh; 
			victorySource.audio.Play ();
			alreadyLaughing=true;
			//audio.clip = laugh;
			//audio.Play();
		}
	}
}
