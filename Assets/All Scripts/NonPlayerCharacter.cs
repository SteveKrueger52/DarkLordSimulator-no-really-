using UnityEngine;
using System.Collections;

public abstract class NonPlayerCharacter : Character {
		Vector2 speed;
		float maxspeed;
		Vector2 acceleration;

	public void Move(){
        Vector3 pos = this.transform.localPosition;

		speed.x = speed.x + acceleration.x;
		speed.y = speed.y + acceleration.y;

		if (speed.magnitude > maxspeed){
			speed.x = (speed.x / (speed.magnitude / maxspeed));
			speed.y = (speed.y / (speed.magnitude / maxspeed));
		}

		pos.x = pos.x + speed.x;
		pos.y = pos.y + speed.y;

        this.transform.localPosition.Set (pos.x, pos.y, 0.0f);
	}

}
