using UnityEngine;
using System.Collections;

public abstract class Character : OurGameObject {

    [SerializeField] public int hp;
    [SerializeField] private int maxHP;
    [SerializeField] private float regen; // we should figure out how this works
    [SerializeField] private int damageValue;

    void attack(Character enemy) {
        enemy.hp -= damageValue;
		if (enemy is Villager) {
			world.getNarrator().OnTriggerVoice(75, new int[9] (0,1,2,3,16,21,18,12,29));
		}
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
