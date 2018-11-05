using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int num;
	public string name;
	public float myFloat;
	public bool cool;
	

	// Use this for initialization
	void Start () {

		// myFloat == .50f;

		//INT SWITCH

		// if(num == 1)
		// 	print("Hurray you picked 1!");
		// }

		// else if(num == 2){
		// 	}
	
		// else{
		// 	print("Boo! You didn't pick 1!")
		// }
			
		
		//NUM SWITCH

		// switch(num){

		// 	case 1: 
		// 		print("You picked " + num );
		// 		break;
		// 	case 3: 
		// 		print("You picked " + num );
		// 		break;
		// 	case 6: 
		// 		print("You picked " + num );
		// 		break;
		// 	case 10: 
		// 		print("You picked " + num );
		// 		break;

		// 	default:
		// 		print("I dont understand" + num);
		// 		break;
		// }

		//STRING SWITCH
		
		// switch(name){
		// 	case "Jason":
		// 		print("Welcome to Camp Crystal Lake " + name + " - love mother"); 
		// 	break;

		// 	case "Michael":
		// 		print("Welcome to Haddonfield, Illinois " + name);
		// 	break;

		// 	case "Freddie":
		// 		print("Welcome to Elm Street " + name);
		// 	break;

		// 	case "Leatherface":
		// 		print("The stars and stripes are big at night...Deep in the heart of Texas ");
		// 	break;

		// 	default:
		// 		print("I dont know " + name);
		// 	break;
		// }

		//FLOAT SWITCH

		// switch(myFloat){
		// 	case .60f:
		// 		print("Flea is " + myFloat + " feet in the air ");
		// 	break;

		// 	case .70f:
		// 		print("Flea is ready for the circus. Flea is " + myFloat + " feet in the air ");
		// 	break;

		// 	case 1.5f:
		// 		print("Flea has reached a max jump height of " + myFloat + " feet in the air ");
		// 	break;

		// 	default:
		// 		print("The height" + myFloat + " does not meet circus requirements ");
		// 	break;
		// }

		//BOOL SWITCH 

		if(cool){
		print("You're cool!");
		}

		else{ 
			print ("Boo! You're lame...");
		}
			
		
		 
		
			

		// }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
