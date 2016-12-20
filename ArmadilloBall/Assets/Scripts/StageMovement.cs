using UnityEngine;
using System.Collections;

public class StageMovement : MonoBehaviour {
	public float smooth = 2.0F;
	public float tiltAngle = 30.0F;
	public GameObject player;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void FixedUpdate()
	{
		#if UNITY_STANDALONE || UNITY_EDITOR
		float tiltAroundZ = -1*Input.GetAxis("Horizontal") * tiltAngle;
		float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
		#elif UNITY_ANDROID || UNITY_IOS || UNITY_WP_8_1
		float tiltAroundX = Input.acceleration.x;
		float tiltAroundZ = Input.acceleration.z;
		#endif
		// Gets the current frontward facing direction of the camera
		Vector3 direction = Camera.main.transform.forward;


		Quaternion zRotation = Quaternion.AngleAxis(tiltAroundZ + player.transform.position.y, direction);
		Vector3 perpendicular = Quaternion.AngleAxis(90, transform.up) * direction;
		Quaternion xRotation = Quaternion.AngleAxis(tiltAroundX, perpendicular);

		transform.rotation = Quaternion.Slerp(transform.rotation, zRotation, Time.deltaTime * smooth);
		transform.rotation = Quaternion.Slerp(transform.rotation, xRotation, Time.deltaTime * smooth);
	}
}

/*
using UnityEngine;
using System.Collections;

public class StageMovement : MonoBehaviour {
    public float smooth = 2.0F;
    public float tiltAngle = 30.0F;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        #if UNITY_STANDALONE || UNITY_EDITOR
            float tiltAroundZ = -1*Input.GetAxis("Horizontal") * tiltAngle;
            float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
        #elif UNITY_ANDROID || UNITY_IOS || UNITY_WP_8_1
            float tiltAroundX = Input.acceleration.x;
            float tiltAroundZ = Input.acceleration.z;
        #endif
		Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
*/