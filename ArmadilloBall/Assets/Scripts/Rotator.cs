using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
		transform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime/2);
    }
}
