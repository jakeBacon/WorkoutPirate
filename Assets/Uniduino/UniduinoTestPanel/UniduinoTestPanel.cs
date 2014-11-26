using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Uniduino;
using Uniduino.Helpers;

#if (UNITY_3_0 || UNITY_3_0_0 || UNITY_3_1 || UNITY_3_2 || UNITY_3_3 || UNITY_3_4 || UNITY_3_5)		
public class UniduinoTestPanel : Uniduino.Examples.UniduinoTestPanel { }
#endif


namespace Uniduino.Examples
{
	
	/// <summary>
	/// Uniduino TestPanel - a GUI tool for easy visualization and manipulation of I/O functions
	/// </summary>
public class UniduinoTestPanel : MonoBehaviour {
	
		public Arduino arduino;
		private int pin;
		private int testLed;
		private bool arduinoOff=true;
		public int[] reading;

	void Start () {		

			arduino = Arduino.global;
			arduino.Setup(ConfigurePins);
		
	}

void ConfigurePins( )
{


			for(int i =8;i<=13;i++){
				arduino.pinMode(i, PinMode.INPUT);
			arduino.reportDigital((byte)(i/8), 1);
			// set the pin mode for the test LED on your board, pin 13 on an Arduino Uno
			arduino.pinMode(testLed, PinMode.OUTPUT);

				print(arduino.digitalRead(i));
			}
		}

		void update(){

			if(Time.time>1 && arduinoOff==true){
				arduino.Connect();
				arduinoOff=false;
			}

			for (int i=8; i<=13; i++) {
			reading[i] = arduino.digitalRead (i);
			}


			print ("hej");

		}

}
}