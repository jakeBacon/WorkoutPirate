using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {


	public int speed;
	public int rowPower;
	public float rowPowerLeft;
	public float rowPowerRight;
	public float recharge;
	public float rowCheckerRight;
	public float rowCheckerLeft;
	public audioController sound;
	public CubeUniduino readings;
	private bool leftRow;
	private bool rightRow;




	// Use this for initialization
	void Start () {
	

		rowPowerLeft = rowPower;
		rowPowerRight = rowPower;

	}
	
	// Update is called once per frame
	void Update () {
	

	if (Time.time >= 3) {

		if(Input.GetButtonDown("right") && rowPowerRight>0){
			rigidbody.AddTorque(new Vector3(0,1,0) * 1,ForceMode.Impulse);
			rigidbody.AddForce(transform.forward*speed,ForceMode.Impulse);
			rowCheckerRight=rowPowerRight;
			rowPowerRight=rowPowerRight-20;
			sound.playAudio(1);

		}
		if(rowPowerRight<rowPower){
			rowPowerRight=rowPowerRight+recharge;
		} else if(rowPowerRight>rowPower){
			rowPowerRight=rowPower;
		}

		//arduinocontrols
		//----------------------------------------------------------------------------
		if(readings.value[11]==1){
			rightRow=true;
		}

		if (readings.value[11]==0 && rowPowerRight>0 && rightRow==true) {
						rigidbody.AddTorque (new Vector3 (0, 1, 0) * (-1), ForceMode.Impulse);
						rigidbody.AddForce (transform.forward * speed, ForceMode.Impulse);
						rowCheckerRight = rowPowerRight;
						rowPowerRight = rowPowerRight - 20;
						sound.playAudio (1);
			rightRow=false;
				}

		if(readings.value[10]==1){
			leftRow=true;
		}
		
		if (readings.value[10]==0 && rowPowerLeft>0 && leftRow==true) {
			rigidbody.AddTorque (new Vector3 (0, 1, 0) * (1), ForceMode.Impulse);
			rigidbody.AddForce (transform.forward * speed, ForceMode.Impulse);
			rowCheckerLeft = rowPowerLeft;
			rowPowerLeft = rowPowerLeft - 20;
			sound.playAudio (1);
			leftRow=false;
		}

		//-------------------------------------------------------------------------

		if(Input.GetButtonDown("left") && rowPowerLeft>0){
			rigidbody.AddTorque(new Vector3(0,1,0)*(-1),ForceMode.Impulse);
			rigidbody.AddForce(transform.forward*speed,ForceMode.Impulse);
			rowCheckerLeft=rowPowerLeft;
			rowPowerLeft=rowPowerLeft-20;
			sound.playAudio(1);


		}
		if(rowPowerLeft<rowPower){
			rowPowerLeft=rowPowerLeft+recharge;
		} else if(rowPowerLeft>rowPower){
			rowPowerLeft=rowPower;
		}
	
	}
		//print (rowCheckerRight);

	}
}
