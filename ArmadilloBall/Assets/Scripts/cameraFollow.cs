// Smooth Follow from Standard Assets
// Converted to C#
// https://gist.github.com/Hamcha/6096905
using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour
{

    // The target we are following
    public Transform target;
    // The distance in the x-z plane to the target
    public float distance = 10.0f;
    // the height we want the camera to be above the target
    public float height = 5.0f;
    // How much we 
    public float heightDamping = 2.0f;
    public float rotationDamping = 3.0f;

    // Place the script in the Camera-Control group in the component menu
    [AddComponentMenu("Camera-Control/Smooth Follow")]

    void LateUpdate()
    {
        // Early out if we don't have a target
        if (!target) return;

        Vector3 direction = target.GetComponent<Rigidbody>().velocity.normalized;
        if (direction.magnitude == 0) return;

        // Calculate the current rotation angles
        float wantedRotationAngle = Vector2.Angle(new Vector2(0, 1), new Vector2(direction.x, direction.z));
        // Angle() uses dot product and only returns [0, 180], so we need to check the cross product
        // to handle (180, 360).
        Vector3 cross = Vector3.Cross(new Vector2(0, 1), new Vector2(direction.x, direction.z));
        if (cross.z > 0)
            wantedRotationAngle = 360 - wantedRotationAngle;
        float wantedHeight = target.position.y + height;

        float currentRotationAngle = transform.eulerAngles.y;
        float currentHeight = transform.position.y;

        // Damp the rotation around the y-axis
        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

        // Damp the height
        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

        // Convert the angle into a rotation
        var currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

        // Set the position of the camera on the x-z plane to:
        // distance meters behind the target
        transform.position = target.position;
        transform.position -= currentRotation * Vector3.forward * distance;

        // Set the height of the camera
        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

        // Always look at the target
        transform.LookAt(target);
    }
}