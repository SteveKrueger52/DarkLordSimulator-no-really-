using UnityEngine;
using System.Collections;

public class StickPointer : MonoBehaviour {
	public GameObject stick;
	public GameObject player;
	public int rotationOffset = 90;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(player.transform.position, Input.mousePosition) < Vector3.Distance(stick.transform.position, player.transform.position)) {
						stick.transform.position = Camera.main.ScreenToWorldPoint (Input.mousePosition) + new Vector3 (0, 0, 10);
				} else {
				
						Vector3 difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
						difference.Normalize ();
						float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;
						transform.rotation = Quaternion.Euler (0f, 0f, rotZ + rotationOffset);
				}
	}
}