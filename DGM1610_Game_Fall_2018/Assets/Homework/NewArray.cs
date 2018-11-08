using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewArray : MonoBehaviour {

	public string[] Pets;

	// Use this for initialization
	void Start () {

		Pets = new string [6];

		Pets[0] = "Dog";
		Pets[1] = "Cat";
		Pets[2] = "Lizard";
		Pets[3] = "Snake";
		Pets[4] = "Hamster";
		Pets[5] = "Fish";

		foreach(string item in Pets){
			print("You have a " + item);
		}

		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
