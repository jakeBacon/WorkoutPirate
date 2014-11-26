using UnityEngine;
using System.Collections;

public class paddlePos : MonoBehaviour {

	public movement Pos;

	private bool rowing=true;
	private float angleX;
	private float rowTimer;
	public Quaternion right;

	// Use this for initialization
	void Start () {
	
		angleX = 1;

	}
	
	// Update is called once per frame
	void Update () {
	
		/*
		if(paddle<Pos.rowPowerRight){
			paddle=paddle+(Pos.rowPowerRight/paddle);
		} else if (Pos.rowPowerRight<paddle){
			paddle=Pos.rowPowerRight;
		}
		*/

		if (Input.GetButtonDown ("right")) {
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

		transform.rotation = Pos.transform.rotation * Quaternion.Euler (angleX,135-Pos.rowPowerRight,0);
		right = transform.rotation;

		//print (rowTimer);
		//print (rowing);

	}
}
