using UnityEngine;
using System.Collections;

public class Minion : NonPlayerCharacter {

    Player leader;
    public Team team;
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
			this.team.addScore (holds.Count);
			holds.Clear ();
		}
	}

	public bool GetClosestEnemy(){
        Character temp = this.leader;
        foreach (OurGameObject m in world.getObjectsWithin(this, range)) {
            if (m is NonPlayerCharacter) {
                if (m is Minion) {
                    if (!sameTeam((Minion)m) && (distanceTo (m).magnitude < distanceTo (temp).magnitude)) {
                        temp = (Minion)m;
                    }
                } else if (distanceTo (m).magnitude < distanceTo (temp).magnitude) {
                    temp = (NonPlayerCharacter)m;
				}
			}
		}
        if (!(temp == this.leader)) {
            return true;
        } else {
            return false;
        }

	}
	
    public virtual bool sameTeam(Minion c) {
        return this.team == c.team;
    }

    public virtual bool sameTeam(Player c) {
        return this.team == c.team;
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
			target = leader.refPos;}

		this.acceleration.x = target.x - this.transform.localPosition.x;
		this.acceleration.y = target.y - this.transform.localPosition.y;
		Move();
	}
}
