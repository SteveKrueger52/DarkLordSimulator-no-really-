﻿using UnityEngine;
using System.Collections;

public class Player : Character {

    public Team team;
    public Vector2 refPos;
    public ArrayList inventory; // Items in inventory
    private int inventoryIndex;

    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {


    }

    void getItem(Item toGet) {
        inventory.Add (toGet);
    }

    void useItem() {
        if (inventory.Count != 0) {
            Item temp = (Item)inventory [inventoryIndex];
            temp.useItem (this);
            inventory.RemoveAt (inventoryIndex);
            if(inventoryIndex >= inventory.Count) {
                inventoryIndex = inventory.Count - 1; 
            }
        }
    }

    public virtual bool sameTeam(Minion c) {
        return this.team == c.team;
    }

    public virtual bool sameTeam(Player c) {
        return this.team == c.team;
    }
}
