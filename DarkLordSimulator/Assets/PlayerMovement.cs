using UnityEngine;
using System.Collections;
using InControl;

public class PlayerMovement : MonoBehaviour {
	// Use this for initialization
	string[] items = new string[5];
	int idx = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		InputDevice device = InputManager.ActiveDevice;
		transform.Translate (new Vector3 (Time.deltaTime * device.LeftStick.X, Time.deltaTime * device.LeftStick.Y, 0f), Space.World);
	}
}
