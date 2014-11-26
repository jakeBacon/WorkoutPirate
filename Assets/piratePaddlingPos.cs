using UnityEngine;
using System.Collections;

public class piratePaddlingPos : MonoBehaviour {

	public paddlePosLeft left;
	public paddlePos right;
	private float yRot;
	private float xRot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//yRot =left.left.eulerAngles.y - right.right.eulerAngles.y;
		yRot = (left.Pos.rowPowerLeft - right.Pos.rowPowerRight)/4;
		xRot =20-((left.Pos.rowPowerLeft + right.Pos.rowPowerRight)/4);
		transform.rotation = right.Pos.transform.rotation * Quaternion.Euler(xRot,yRot,0);
		print ("right"+ yRot);
	}
}
