using UnityEngine;
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
            temp.activateItem (this);
            inventory.RemoveAt (inventoryIndex);
            if(inventoryIndex >= inventory.Count) {
                inventoryIndex = inventory.Count - 1; 
            }
        }
    }

    public void convert (Villager v) {
        // How Do???
    }

    override public bool sameTeam(Minion c) {
        return this.team == c.team;
    }

    override public bool sameTeam(Player c) {
        return this.team == c.team;
    }
}
