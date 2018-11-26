using UnityEngine;
using System.Collections;

public class AmmoPickup : MonoBehaviour {
	
	public int AmmoToAdd;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D> () == null)
			return;

		AmmoManager.AddAmmo (AmmoToAdd);

		Destroy (gameObject);
	}
}
