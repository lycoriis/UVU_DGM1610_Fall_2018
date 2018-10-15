using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

	//Movement Variables
	public float MoveSpeed;
	public bool MoveRight;

	//Wall Ckack
	public Transform WallCheck;
	public float WallCheckRadius;
	public LayerMask WhatIsWall;
	private bool HittingWall;

	//Edge Check
	private bool NotAtEdge;
	public Transform EdgeCheck;
	
	// Update is called once per frame
	void Update () {
		
	}
}
