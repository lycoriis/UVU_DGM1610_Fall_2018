using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
	
	public GameObject CurrentCheckPoint;
	private Rigidbody2D Player;

	//Particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	//Respawn Delay
	public float RespawnDelay;

	//Point Penalty on Death
	public int PointPenaltyOnDeath;

	//Store Gravity Value
	private float GravityStore;

	//Use this for initialization
	void Start () {
		// Player = FindObjectofType<Rigidbody2D> ();
	}

		public void RespawnPlayer(){
			StartCoroutine ("RespawnPlayerCo");
		}

		public IEnumerator RespawnPlayerCo(){
			
			//Generate Death Partcle
			Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);

			//Hide Player
			//player.enabled = false;
			Player.Getcomponent<renderer> ().enabled = false;

			//Gravity Reset
			GravityStore = player.GetComponent<Rigidbody2D>().gravityScale;
			Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
			Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			
			//Point Penalty
			ScoreManager.AddPoints(-PointPenaltyOnDeath);

			//Debug Message
			Debug.Log ("Player Respawn");
		}
}
