//Used Aaron Acosta's PlayMusicScript from "Really Bad Game" as a template

using UnityEngine;
using System.Collections;

public class PlayMusicScript : MonoBehaviour {

	public AudioSource backgroundMusic;

	void Start () {
		if (!backgroundMusic.isPlaying) {
			backgroundMusic.Play ();
		}
		if (AudioListener.pause) {
			AudioListener.pause = false;
		}
		if (!backgroundMusic.loop)
			backgroundMusic.loop = true;
	}
	
/*	void Update () {
		if (!backgroundMusic.isPlaying)
			backgroundMusic.Play ();
	}
*/ //commented out to prevent music from playing more than once
}
