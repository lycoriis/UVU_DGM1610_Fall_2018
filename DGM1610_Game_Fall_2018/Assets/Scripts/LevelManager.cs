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
		player = FindObjectofType<Rigidbody2D> ();
	}

		public void RespawnPlayer(){
			StartCorouting ("RespawnPlayerCo");
		}

		public IEnumerator RespawnPlayerCo(){
			
			//Generate Death Partcle
			Istantiate (deathParticle, player.transform.position, player.transform.rotation);

			//Hide Player
			//player.enabled = false;
			player.Getcomponent<renderer> ().enabled = false;

			//Gravity Reset
			gravityStore = player.GetComponent<Rigidbody2D>().gravityScale;
			player.GetComponent<Rigidbody2D>().gravityScale = 0f;
			player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			
			//Point Penalty
			ScoreManager.AddPoints(-PointPenaltyOnDeath);
		}
}
