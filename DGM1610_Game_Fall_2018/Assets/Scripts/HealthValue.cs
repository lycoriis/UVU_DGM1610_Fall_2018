using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthValue : MonoBehaviour {

	public const int fullHealth = 100;
	public int currentHealth = fullHealth;

	public void WasDamage(int amount){

		currentHealth -= amount;

		if (currentHealth <= 0){
		
		currentHealth = 0;
		Debug.Log("Too Bad! Player Dead!");
		}
	}
}
