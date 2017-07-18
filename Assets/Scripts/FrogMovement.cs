using UnityEngine;
using System.Collections;

public class FrogMovement : MonoBehaviour {

	public float jumpElevationInDegrees = 45;
	public float jumpSpeedInCMPS = 700;
	public float jumpGroundClearance = 200;
	public float jumpSpeedTolerance = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool isOnGround = Physics.Raycast(transform.position, -transform.up, jumpGroundClearance);
		Debug.DrawRay(transform.position, -transform.up * jumpGroundClearance);
		var speed = GetComponent<Rigidbody>().velocity.magnitude;
		bool isNearStationary = speed < jumpSpeedTolerance;
		if ((Input.GetKeyDown(KeyCode.Space) || GvrViewer.Instance.Triggered) && isOnGround && isNearStationary)
		{
			var camera = GetComponentInChildren<Camera>(); //Debug.DrawRay(transform.position, camera.transform.forward, Color.green); //Debug.DrawRay(transform.position, jumpVector, Color.green);
			var projectedLookDirection = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up); //Debug.DrawRay(transform.position, projectedLookDirection, Color.blue);
			var radiansToRotate = Mathf.Deg2Rad * jumpElevationInDegrees;
			var unnormalizedJumpDirection = Vector3.RotateTowards(projectedLookDirection, Vector3.up, radiansToRotate, 0);
			var jumpVector = unnormalizedJumpDirection.normalized * jumpSpeedInCMPS; //Debug.DrawRay(transform.position, jumpVector.normalized, Color.red);
			GetComponent<Rigidbody>().AddForce(jumpVector, ForceMode.VelocityChange); // acceleration is the worst change - constant velocity
		}
	}
}
