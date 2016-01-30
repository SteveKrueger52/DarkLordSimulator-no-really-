using UnityEngine;
using System.Collections;

public class Minion : NonPlayerCharacter {

		Player leader;
		Team team;
		ArrayList holds; // All Villagers being held
		int holdCapacity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	//get behavior
		if (far from player){
			//set target to player
		} else if (closest enemy within range){
			//set target to enemy
		} else if (closest Villager within range){
			//set target to villager
		} else {
			//set target to player}

		Move ();
	}
}
