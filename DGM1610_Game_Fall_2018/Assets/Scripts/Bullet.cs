using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public GameObject PlayerDeath;

	public GameObject EnemyBullet;

	public Rigidbody2D Enemy;


	// void OnCollisionEnter(){
	// 	Destroy(gameObject);
	// }

	void OnCollisionEnter(Collision collision){
		var hit = collision.gameObject;
		var health = hit.GetComponent<Health>();
		if (health != null){
			
			health.TakeDamage(20);
		}

		Destroy(gameObject);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			Instantiate(PlayerDeath, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			
		}

		Destroy(gameObject);
	}

	void OnCollisionEnter2D(Collision2D other){
		Instantiate(EnemyBullet, transform.position, transform.rotation);
		if(other.gameObject.tag == "Ground"){
		Destroy(gameObject);}
	}


	void Start() {

		StartCoroutine (Attack());
	}

	IEnumerator Attack(){
		yield return new WaitForSeconds (Random.Range (1, 3));

		Instantiate (EnemyBullet, transform.position, Quaternion.identity);

		StartCoroutine (Attack());
	}
		
	// void OnCollisionEnter2D(Collision2D target){
	// 	if (target.gameObject.tag == "Player"){
	// 		//empty script
			
	// 	}

	// 	if(target.gameObject.tag == "Ground"){
	// 		Destroy (gameObject);
	// 	}
	// }
	
}
