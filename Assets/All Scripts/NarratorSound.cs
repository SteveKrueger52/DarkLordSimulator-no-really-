﻿using UnityEngine;
using System.Collections;

	public class NarratorSound : MonoBehaviour {
	public AudioSource source;
	public AudioClip[] quotes;
	[SerializeField] public Game world;
	int x = 0;
	int timer = 0;

	// Use this for initialization
	void Start () {
		OnTriggerVoice(100, new int[4] {8,5,20,13} ) ;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer > 0) {
			timer--;
		}
	}

	public void OnTriggerVoice(int odds, int [] clips) {
		int newOdds = Random.Range (0, 100);
		int clip = Random.Range (0, clips.Length - 1);
		if ((newOdds > odds) && (timer == 0)) {
			source.clip = quotes [clips [clip]];
			source.PlayOneShot (source.clip);
			timer = 120;
		}
	}




	public IEnumerator OnTriggerImportantVoice(AudioClip[] clips) {
		int clip = Random.Range (0, clips.Length - 1);
		if (timer > 0) {
			source.clip = clips [clip];
			source.PlayOneShot (source.clip);
		}
		else {
			yield return new WaitForSeconds(5);
		}
	}
}
