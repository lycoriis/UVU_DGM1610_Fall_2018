using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	//Shoot Variables
	public Transform FirePoint;
	public GameObject Projectile;
	public int Ammo;

	void Start(){
		// Projectile = GameObject.Find("Projectile");

	}

	// Update is called once per frame
	void Update () {
		if (Ammo < 0){
			Ammo = 0;
		}

		

		if(Input.GetKeyDown(KeyCode.RightControl)){
			Instantiate(Projectile,FirePoint.position, FirePoint.rotation);
			Ammo--;
		}

		
		
		
		
		

		
	}
	
	
}
