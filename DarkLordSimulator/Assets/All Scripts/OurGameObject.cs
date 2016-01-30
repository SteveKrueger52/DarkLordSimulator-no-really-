using UnityEngine;
using System.Collections;

public abstract class OurGameObject : MonoBehaviour {

	// this.transform gets the Transform of the object, which includes location and scale
	public bool isBlocking;

    public Vector3 distanceTo(OurGameObject other) {
        return new Vector3 (
            other.transform.localPosition.x - this.transform.localPosition.x,
            other.transform.localPosition.y - this.transform.localPosition.y);
    }

}
