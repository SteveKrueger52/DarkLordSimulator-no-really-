using UnityEngine;
using System.Collections;

public class Minion : NonPlayerCharacter {
    public Player leader;
    public Team team;
    ArrayList holds = new ArrayList(); // All Villagers being held
    int holdCapacity = 1;
    public Vector2 target;
    static int range = 5;
    static int range2 = 10;

    // Use this for initialization

    public void Sacrifice(){
        if (holds.Count > 0) {
			int z = 0;
			foreach (Villager v in holds) {
				z += v.sacrificeValue;
			}
            this.team.addScore (z);
            holds.Clear ();
        }
    }

    public void GetClosestEnemy(){
        Character temp = this.leader;
        foreach (NonPlayerCharacter m in world.getObjectsWithin(this, range)) {
            if (m is Minion) {
                if (!sameTeam((Minion)m) && (distanceTo (m).magnitude < distanceTo (temp).magnitude)) {
                    temp = (Character) m;
                }
            } else if (distanceTo (m).magnitude < distanceTo (temp).magnitude) {
                temp = (Character) m;

            }
        }
        if (!(temp == this.leader)) {
            target = new Vector2(temp.transform.localPosition.x, temp.transform.localPosition.y);
            //return true;
        } else {
            target = leader.refPos;
            //return false;
        }

    }

    override public bool sameTeam(Minion c) {
        return this.team == c.team;
    }
    // Update is called once per frame
    void Update() {

        //get behavior
        if (distanceTo(leader).magnitude >= range2) {
            target = leader.refPos;
        } else if (world.getObjectsWithin(this, range2) != null){ 
            int rand = Random.Range (0, world.getObjectsWithin (this, range2).Count - 1);
            if (((OurGameObject)world.getObjectsWithin (this, range2) [rand]) is Villager) {
                target = ((OurGameObject)world.getObjectsWithin (this, range2) [rand]).transform.position;
            }
        }
        this.acceleration =new Vector2(
            target.x - this.transform.localPosition.x,
            target.y - this.transform.localPosition.y);
        Move();
    }
}
