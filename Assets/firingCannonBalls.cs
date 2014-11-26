using UnityEngine;
using System.Collections;

public class firingCannonBalls : MonoBehaviour {



	public Rigidbody cannonBall;
	public Transform muzzle;
	public float firingPower;
	private float fireTime;
	private bool fireEnabler;
	public float firePowerRemember;
	public bool firing;
	public audioController sound;
	public CubeUniduino readings;
	public bool fireOn;


	// Use this for initialization
	void Start () {
		firing = false;
		fireOn = false;
		firePowerRemember = firingPower;
	}
	
	// Update is called once per frame
	void Update () {
	
		//print ("value 9 is" + readings.value[9]);

		if(Input.GetButtonDown("Fire1")){
		
			fireTime = Time.time;
			firingPower=firingPower+700;
			fireEnabler=true;
			firing=true;

		}

		//---------------------------------------------

		if(readings.value[9]==0 && fireOn==true){
			
			fireTime = Time.time;
			firingPower=firingPower+700;
			fireEnabler=true;
			firing=true;

			fireOn=false;
			sound.playAudio(0);
		}

		if(readings.value[9]==1){
			fireOn=true;

		}


		//---------------------------------------------

		if(Time.time-fireTime>=1.5f && fireEnabler ){
			GameObject bullet;
			bullet = Instantiate(cannonBall, muzzle.position, muzzle.rotation) as GameObject;
			bullet.rigidbody.AddForce(muzzle.forward*firingPower*2);
			fireEnabler=false;
			firingPower=firePowerRemember;
			firing = false;
			sound.playAudio(0);
		}

	}
}
