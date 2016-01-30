using UnityEngine;
using System.Collections;

public class Minion : NonPlayerCharacter {

	Player leader;
	Team team;
	ArrayList holds; // All Villagers being held
	int holdCapacity;
	Vector2 target;
	int range;
	int range2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
        //get behavior
        if (distanceTo (leader).magnitude > range2) {
            target = leader.refPos;
            //} else if (enemy within range){
            //set target to closest enemy
            //} else if (Villager within range){
            //set target to villager
        } else {
            target = leader.refPos;
        }

        move ();
    }

    void move() {
        
    }
}
