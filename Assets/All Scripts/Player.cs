using UnityEngine;
using System.Collections;

public class Player : Character {

    public Team team;
    public Vector2 refPos;
    public ArrayList inventory; // Items in inventory
    private int inventoryIndex;
	public int souls = 0;
    [SerializeField] GameObject toSpawn;

    // Use this for initialization
    void Start () {
        //team.addPlayer (this);
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) {
            
        }
    }

    void addItem(Item toGet) {
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

    public void convert () {
        foreach (Villager m in world.getObjectsWithin(this, 0.5f)) {
            m.die ();
            GameObject temp = Instantiate (toSpawn.gameObject);
            Minion temp2 = temp.GetComponent<Minion>();
            temp2.transform.localPosition = this.transform.localPosition;

            temp2.team = this.team;
            temp2.target = this.refPos;
            temp2.leader = this;

            world.addObject(temp.GetComponent<OurGameObject>());
        }
    }

    override public bool sameTeam(Minion c) {
        return this.team == c.team;
    }

    override public bool sameTeam(Player c) {
        return this.team == c.team;
    }
}
