using UnityEngine;
using System.Collections;
using InControl;

public class PlayerMovement : MonoBehaviour {
    // Use this for initialization
    public int playerNum;
    string[] items = new string[5];
    int idx = 0;
    Animation anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update () {
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
        if (device.LeftStick.X == 0 && device.LeftStick.Y == 0) {
            anim.Play ("Idle Cultist");
        }
        else {
            anim.Play ("Cultist Walk");
        }
        transform.Translate (new Vector3 (Time.deltaTime * device.LeftStick.X, Time.deltaTime * device.LeftStick.Y, 0f), Space.World);    
    }
}