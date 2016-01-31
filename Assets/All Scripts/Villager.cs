using UnityEngine;
using System.Collections;

public class Villager : NonPlayerCharacter {

    public int sacrificeValue;
    Vector2 target;
    int refresh = 50;

	// Use this for initialization
	void Start () {
        target = new Vector2 (Random.Range (-20, 20), Random.Range (-20, 20));

	}

    override public bool sameTeam(Character c) {
        return false;
    }

    // Update is called once per frame
    void Update () {
        refresh--;
        if (refresh == 0) {
            target.x = Random.Range ((this.transform.localPosition.x - 50), (this.transform.localPosition.x + 50));
            target.y = Random.Range ((this.transform.localPosition.y - 50), (this.transform.localPosition.y + 50));
            refresh = 300;
        }

        acceleration = new Vector2 (
            target.x - this.transform.localPosition.x,
            target.y - this.transform.localPosition.y);
        Move ();
    }
}
