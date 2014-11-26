using UnityEngine;
using System.Collections;

public class MenuScreenIntroSong : MonoBehaviour {

	public AudioClip introSong;

	// Use this for initialization
	void Start () {
		audio.clip = introSong;
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
