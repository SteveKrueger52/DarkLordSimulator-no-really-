using UnityEngine;
using System.Collections;

public abstract class NonPlayerCharacter : Character {
    Vector2 speed = new Vector2();
		float maxspeed = 0.05f;
		protected Vector2 acceleration;

	public void Move(){
        Vector3 pos = this.transform.localPosition;

        speed = new Vector2(speed.x + acceleration.x, speed.y + acceleration.y);

		if (speed.magnitude > maxspeed){
            speed = new Vector2(
                (speed.x / (speed.magnitude / maxspeed)),
                (speed.y / (speed.magnitude / maxspeed)));
		}
        pos = new Vector2 (pos.x + speed.x, pos.y + speed.y);

        this.transform.localPosition = pos;
	}

    public virtual void die() {
        world.removeObject (this);
        Destroy (this);
    }
        
}
