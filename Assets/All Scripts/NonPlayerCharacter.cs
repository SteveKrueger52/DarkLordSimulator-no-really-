using UnityEngine;
using System.Collections;

public abstract class NonPlayerCharacter : Character {
		Vector2 speed;
		float maxspeed;
		Vector2 acceleration;

	public void Move(){
		speed.x = speed.x + acceleration.x;
		speed.y = speed.y + acceleration.y;

		if (speed.magnitude > maxspeed){
			speed.x = (speed.x / (speed.magnitude / maxspeed));
			speed.y = (speed.y / (speed.magnitude / maxspeed));
		}

		this.transform.localPosition.x = this.transform.localPosition.x + speed.x;
		this.transform.localPosition.y = this.transform.localPosition.y + speed.y;
	}

}
