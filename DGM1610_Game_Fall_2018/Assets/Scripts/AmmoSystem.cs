using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSystem : MonoBehaviour {

	bool canFire = trure;
	float cooldownTime = 0.5f;
	int maxClip = 10;
	int reserve = 10;
	
	void Start () {
		AmmoText = GetComponent<Text>();

		Ammo = 0;
		
	}

	void Update(){
		if(Input.GetButton("Fire1") && canFire)
		Fire(Fire);

	}

	void WeaponCoolDown() {

	}


	
}
