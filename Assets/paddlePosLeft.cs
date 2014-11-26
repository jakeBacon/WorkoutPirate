using UnityEngine;
using System.Collections;

public class paddlePosLeft : MonoBehaviour {

	public movement Pos;

	private bool rowing=true;
	private float angleX;
	private float rowTimer;
	public Quaternion left;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("left")) {
			rowTimer=30;
			rowing = true;
		} 
		
		if (rowTimer > 0) {rowTimer=rowTimer-1;} 
		if(rowTimer<=0) {rowing=false;}
		
		if(rowing==true){
			angleX=angleX+1;
		} if(rowing==false){
			angleX=angleX-1;
		}
		
		if(angleX>30){
			angleX=30;
		} if(angleX<0){
			angleX=0;
		}

	
		transform.rotation = Pos.transform.rotation * Quaternion.Euler (angleX,Pos.rowPowerLeft-135,0);

		left = transform.rotation;

	}
}
