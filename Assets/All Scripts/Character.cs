using UnityEngine;
using System.Collections;

public abstract class Character : OurGameObject {

	public int hp;
	private int maxHP;
	private float regen; // we should figure out how this works
    private int damageValue;

    void attack(Character enemy) {
        enemy.hp -= damageValue;
        if (enemy.hp < 0) {
            enemy.die ();
        }
    }

    void die() {
        //TODO
    }

    public virtual bool sameTeam (Character c) {
        return c.sameTeam(this);
    }
    public virtual bool sameTeam(Minion c) {
        return c.sameTeam(this);
    }

    public virtual bool sameTeam(Player c) {
        return c.sameTeam(this);
    }
}
