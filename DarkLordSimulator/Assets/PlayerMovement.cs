using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)) {
			GetComponent<Rigidbody2D>().transform.Translate(new Vector2(0, .1f));
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			GetComponent<Rigidbody2D>().transform.Translate(new Vector2(0, -0.1f));
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D>().transform.Translate(new Vector2(0.1f, 0));
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			GetComponent<Rigidbody2D>().transform.Translate(new Vector2(-0.1f, 0));
		}
	
	}
}
