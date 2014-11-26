using UnityEngine;
using System.Collections;

public class waveCrashing : MonoBehaviour {

	private float x;
	private float sX;
	private float sZ;
	private float localX;
	private float localZ;

	// Use this for initialization
	void Start () {
	
		sX = 0.1f;
		sZ = 0.1f;

	}
	
	// Update is called once per frame
	void Update () {
	
		x = x + 0.01f*Time.deltaTime;
		transform.rotation = new Quaternion(transform.rotation.x, Mathf.Sin (x)/100,transform.rotation.z, transform.rotation.w);

		sX = Random.Range (sX-0.01f,sX+0.01f);
		sZ = Random.Range (sZ-0.01f,sZ+0.01f);
		if (sX > 2) {
			sX=2;
		} else if(sX<-2){
			sX=-2;
		}
		if (sZ > 1) {
			sZ=1;
		} else if(sZ<-1){
			sZ=-1;
		}

		transform.localScale += new Vector3 (Mathf.Sin (sX)/10,0,Mathf.Sin(sZ)/10);


	}
}
