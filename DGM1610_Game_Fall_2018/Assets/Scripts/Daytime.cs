using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daytime : MonoBehaviour {
	public string Time;

	// Use this for initialization
	void Start () {
		if(Time == "Day")
			print("It is" + Time);

			else if(Time == "Sunrise");
			else if(Time == "Sunset");
			else if(Time == "Night");

			else
				print("It is" + Time);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
