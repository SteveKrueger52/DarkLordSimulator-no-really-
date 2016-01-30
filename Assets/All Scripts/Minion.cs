using UnityEngine;
using System.Collections;

public class Minion : NonPlayerCharacter {

		Player leader;
		Team team;
		ArrayList holds; // All Villagers being held
		int holdCapacity;
		Vector2 target;
	NonPlayerCharacter temp;
	int range;
	int range2;

	// Use this for initialization
	void Start () {

	}

	public void Sacrifice(){
		if (holds.Count > 0) {
			this.team.AddScore (holds.Count);
			holds.Clear ();
		}
	}

	public bool GetClosestEnemy(){
		
		foreach (OurGameObject m in Game.getObjectsWithin(this, range)) {
			temp = this.leader;
			if (m is NonPlayerCharacter) {
				if (m is Minion) {
					if ((this.team != (Minion)m.team) && distanceTo (m) < distanceTo (temp)) {
						temp = m;
					}
				} else if (distanceTo (m) < distanceTo (temp)) {
					temp = m;
				}
			}
		}
		if (!(temp is this.leader)){
			return true;
		} else return false;

	}
	
	// Update is called once per frame
	void Update () {
		
	//get behavior
		if (distanceTo(leader).magnitude > range2){
			target = leader.refPos;
		} else if (GetClosestEnemy()){
			target.x = temp.transform.localPosition.x;
			target.y = temp.transform.localPosition.y;
		} else {
			target = leader.refpos;}

		this.acceleration.x = target.x - this.transform.localPosition.x;
		this.acceleration.y = target.y - this.transform.localPosition.y;
		Move();
	}
}
