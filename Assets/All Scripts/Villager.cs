﻿using UnityEngine;
using System.Collections;

public class Villager : NonPlayerCharacter {

		int sacrificeValue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    override public bool sameTeam(Character c) {
        return false;
    }
}
