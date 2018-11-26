﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public const int maxHealth = 100;
	public int currentHealth = maxHealth;
    public RectTransform healthBar;

	public void WasDamage(int amount){

		currentHealth -= amount;

		if (currentHealth <= 0){
		
		currentHealth = 0;
		
		Debug.Log("Too Bad! Player Dead!");
		}

        healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);
	}
}
