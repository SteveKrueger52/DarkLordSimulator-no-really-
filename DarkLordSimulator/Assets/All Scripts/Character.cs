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
}
