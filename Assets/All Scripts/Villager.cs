using UnityEngine;
using System.Collections;

public class Villager : NonPlayerCharacter {

		int sacrificeValue;
	Vector2 target;
	int refresh = 0;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		refresh--;
		if (refresh == 0) {
			target.x = Random.Range ((this.transform.localPosition.x - 50), (this.transform.localPosition.x + 50));
			target.y = Random.Range ((this.transform.localPosition.y - 50), (this.transform.localPosition.y + 50));
			refresh = 300;
		}

		Move ();
	}

    override public bool sameTeam(Character c) {
        return false;
    }
}
