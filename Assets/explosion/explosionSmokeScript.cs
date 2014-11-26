using UnityEngine;
using System.Collections;

public class explosionSmokeScript : MonoBehaviour {

	public float smokeSpeed;
	public float smokeDecreaser;
	public float smokeScale;
	public float smokeScaleDecreaser;

	// Use this for initialization
	void Start () {
	
		transform.localScale = new Vector3 (124,48,124);

	}
	
	// Update is called once per frame
	void Update () {
	
		transform.localScale += new Vector3 (smokeScale,smokeScale/4,smokeScale);

		if (smokeScale > 0) {
		smokeScale = smokeScale - smokeScaleDecreaser;
				} 


		transform.Translate (new Vector3(0,1,0) * smokeSpeed);

		smokeSpeed= smokeSpeed-smokeDecreaser;

		Color textureColor = renderer.material.color;
		textureColor.a = Mathf.PingPong(Time.time, 2) / 2;
		renderer.material.color = textureColor;

		Destroy (gameObject, 3);

	}
}
