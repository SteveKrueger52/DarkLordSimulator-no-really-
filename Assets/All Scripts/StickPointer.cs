using UnityEngine;
using System.Collections;
using InControl;

public class StickPointer : MonoBehaviour {
	public GameObject stick;
	public GameObject player;
	public int rotationOffset = 90;
	public int playerNum;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		InputDevice device = InputManager.ActiveDevice;
		var inputDevice = (InputManager.Devices.Count > playerNum) ? InputManager.Devices[playerNum] : null;
		if (inputDevice == null)
		{
			Destroy(this.gameObject);
		}
		else
		{
			UpdateCubeWithInputDevice(inputDevice);
		}
	}

	void UpdateCubeWithInputDevice(InputDevice device)
	{
		if (device.RightStick.X == 0 && device.RightStick.Y == 0 ) {
			stick.transform.position = player.transform.position;
		} 

		else {
			stick.transform.position = player.transform.position + new Vector3 (device.RightStick.X * 3, device.RightStick.Y * 3, stick.transform.position.z);
			}
	}
}