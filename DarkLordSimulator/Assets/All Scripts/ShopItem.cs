﻿using UnityEngine;
using System.Collections;

public class ShopItem : WorldTerrain {

		Item toSell;
		int price;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Transaction(Player p) {
		if (p.credits > price) {
			p.addItem(toSell);
		}
	}
}
