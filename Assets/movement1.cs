using UnityEngine;
using System.Collections;

public class movement1 : MonoBehaviour {

	public int speed;
	public int rowPower;
	public float rowPowerLeft;
	public float rowPowerRight;
	public float recharge;
	public float rowCheckerRight;
	public float rowCheckerLeft;
	
	// Use this for initialization
	void Start () {
		
		rowPowerLeft = rowPower;
		rowPowerRight = rowPower;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButtonDown("right1") && rowPowerRight>0){
			rigidbody.AddTorque(new Vector3(0,1,0) * 1,ForceMode.Impulse);
			rigidbody.AddForce(transform.forward*speed,ForceMode.Impulse);
			rowCheckerRight=rowPowerRight;
			rowPowerRight=rowPowerRight-20;
		}
		if(rowPowerRight<rowPower){
			rowPowerRight=rowPowerRight+recharge;
		} else if(rowPowerRight>rowPower){
			rowPowerRight=rowPower;
		}
		
		
		
		if(Input.GetButtonDown("left1") && rowPowerLeft>0){
			rigidbody.AddTorque(new Vector3(0,1,0)*(-1),ForceMode.Impulse);
			rigidbody.AddForce(transform.forward*speed,ForceMode.Impulse);
			rowCheckerLeft=rowPowerLeft;
			rowPowerLeft=rowPowerLeft-20;
		}
		if(rowPowerLeft<rowPower){
			rowPowerLeft=rowPowerLeft+recharge;
		} else if(rowPowerLeft>rowPower){
			rowPowerLeft=rowPower;
		}
		
		//print (rowCheckerRight);
		
	}
}
