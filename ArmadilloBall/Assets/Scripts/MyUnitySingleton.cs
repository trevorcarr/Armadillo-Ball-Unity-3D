//http://answers.unity3d.com/questions/11314/audio-or-music-to-continue-playing-between-scene-c.html

using UnityEngine;
using System.Collections;

public class MyUnitySingleton : MonoBehaviour {

	private static MyUnitySingleton instance = null;

	public static MyUnitySingleton Instance {
		get { 
			return instance; 
		}
	}

	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} 
		else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

	void Update() {
		DontDestroyOnLoad (this.gameObject);
	}
}