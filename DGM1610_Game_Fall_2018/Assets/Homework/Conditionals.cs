using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour {
	public string Weather;

	// Use this for initialization
	void Start () {
		if(Weather == "Raining")
			print("Weather is " + Weather);

			else if(Weather == "Snowing");
			else if(Weather == "Sunny");
			else if(Weather == "Cloudy");

			else
				print ("I dont know" + Weather);
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
