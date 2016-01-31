﻿using UnityEngine;
using System.Collections;

public abstract class Character : OurGameObject {

    [SerializeField] public int hp;
    [SerializeField] private int maxHP;
    [SerializeField] private float regen; // we should figure out how this works
    [SerializeField] private int damageValue;

    protected void attack(Character enemy) {
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
