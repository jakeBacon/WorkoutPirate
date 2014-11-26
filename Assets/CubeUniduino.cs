using UnityEngine;
using System.Collections;
using Uniduino;

public class CubeUniduino : MonoBehaviour {

	public Arduino arduino;
	public float speed;
	public int pin = 0;
	public int pinValue;
	public int[] value;



	void Start( )
	{
		arduino = Arduino.global;
		arduino.Setup(ConfigurePins);
	}
	
	void ConfigurePins( )
	{

		//arduino.pinMode(pin, PinMode.INPUT);
		//arduino.reportDigital((byte)(pin/8), 1);


		for (int i=8; i<=13; i++) {
			arduino.pinMode (i, PinMode.INPUT);
			arduino.reportDigital ((byte)(i / 8), 1);
		}

		// set the pin mode for the test LED on your board, pin 13 on an Arduino Uno
	}


	void Update () 
	{       
		// read the value from the digital input
		pinValue = arduino.digitalRead(pin);
		for(int i=8;i<=13;i++){
			value[i] = arduino.digitalRead(i);
		}

		//print (pinValue);
		// apply that value to the test LED
		transform.rotation = Quaternion.Euler(0,pinValue*speed,0);

	}
}
