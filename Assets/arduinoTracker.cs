using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class arduinoTracker : MonoBehaviour {

		
		public float speed;
		private float amountToMove;
	public int maxValue;
	public int minValue;
	public int currentValue;
		
		SerialPort sp = new SerialPort("COM8", 9600);
		
		// Use this for initialization
		void Start () {
			sp.Open();
			sp.ReadTimeout = 1;


			maxValue=sp.ReadByte();
			minValue=sp.ReadByte();

		}
		
		// Update is called once per frame
		void Update () {
			//amountToMove = speed * Time.deltaTime;
			
			if (sp.IsOpen) {
				try {
					trackObject(sp.ReadByte());
					//print(sp.ReadByte());
				currentValue=sp.ReadByte();
				}

				catch (System.Exception) {
					
				}
			}
		}
		
		void trackObject (int value) {

		if(value>maxValue){
			maxValue=value;

		}

		if(value<minValue){
			minValue=value;

		}
		print(maxValue + "maxValue"+minValue+ "minValue");

		}
	}


