using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
	public int MoveSpeed;
	public float JumpHeight;

	//Player Grounded Variables
		public Transform GroundCheck;
		public float GroundCheckRadius;
		public LayerMask WhatIsGround;
		private bool Grounded;

	// Use this for initialization
	void Start () {
		print("Hello World!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
	

	void FixedUpdate () {
		Grounded = Physhics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatisGround);

	}

	// This
	void Update () {
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
		Jump();
	}
	
	

	//This code makes the character move side to side using A&D keys
	if(Input.GetKeyDown (KeyCode.D))
{

}	
	public void Jump(){
		GetComponent<RigidBody2D>().velocity = new Vector2(GetComponent<RigidBody2D>().velocity.y, JumpHeight);
	