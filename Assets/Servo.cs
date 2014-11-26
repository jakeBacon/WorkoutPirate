using UnityEngine;
using System.Collections;
using Uniduino;

public class Servo : MonoBehaviour {

	public Arduino arduino;
	
	public int pin = 0;
	public int pinValue;
	private GameObject cube;

	void Start( )
	{
		arduino = Arduino.global;
		arduino.Setup(ConfigurePins);
		cube = GameObject.Find("Cube");
	}
	
	void ConfigurePins( )
	{
		arduino.pinMode(pin, PinMode.INPUT);
		arduino.reportDigital((byte)(pin/8), 1);
		// set the pin mode for the test LED on your board, pin 13 on an Arduino Uno
	}
	
	void Update () 
	{       
		// read the value from the digital input
		pinValue = arduino.digitalRead(pin);
		// apply that value to the test LED
		cube.transform.rotation = Quaternion.Euler(0,pinValue*0.2f,0);     
	}
}
