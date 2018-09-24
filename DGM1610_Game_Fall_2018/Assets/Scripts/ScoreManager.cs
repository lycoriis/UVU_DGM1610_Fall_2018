﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
	public static int score;

	Text ScoreText;

	// Use this for initialization
	void Start () {
		ScoreText = GetComponent<Text>();

		Score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Score < 0)
			Score = 0;
			Scoretext.text = " " + Score;
	}
	
	public static void AddPoints (int PointsToAdd) {
		Score += PointsToAdd;
	}
}
