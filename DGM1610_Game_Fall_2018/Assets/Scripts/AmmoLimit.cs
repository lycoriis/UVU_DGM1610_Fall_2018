using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoLimit : MonoBehaviour {

	[System.Serializable]
	public class Ammo {

		public int MaxAmmo;
		public int CurrentAmmo;

		public Ammo(int maxAmmo){

			MaxAmmo = maxAmmo;
		}

		public void MaxOutType(){
				
			CurrentAmmo = MaxAmmo;
		}

		public void GetAmmo (int amount){

			CurrentAmmo += amount;
		}

		public void UseAmmo(int numOf){

			CurrentAmmo -= numOf;
		}
		


	}
}
