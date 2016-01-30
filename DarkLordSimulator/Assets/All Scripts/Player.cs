using UnityEngine;
using System.Collections;

public class Player : Character {

		public Team team;
		public Vector2 refPos;
	    public Item[] inventory;
		private int inventoryIndex = 0;
	    public int credits = 200;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Adds an Item to Inventory
	public void addItem(Item i) {
		inventory [inventoryIndex] = i;
		inventoryIndex++;
	}
}
