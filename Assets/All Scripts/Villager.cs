using UnityEngine;
using System.Collections;

public class Villager : NonPlayerCharacter {

		public int sacrificeValue;

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
