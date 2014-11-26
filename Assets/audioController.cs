using UnityEngine;
using System.Collections;

public class audioController : MonoBehaviour {

	public AudioClip[] audioclips;
	public AudioSource audioPlayer;
	public AudioSource[] soundSources;


	// Use this for initialization
	void Start () {

		for(int i = 0; i<=5;i++){
			soundSources[i]=Instantiate(audioPlayer, transform.position,transform.rotation) as AudioSource;
			soundSources[i].audio.clip = audioclips[i];
		}
		
	}
	

	
	// Update is called once per frame
	void Update () {
	
	}

	public void playAudio(int clipNumber){
		soundSources[clipNumber].audio.Play();
	}
}
