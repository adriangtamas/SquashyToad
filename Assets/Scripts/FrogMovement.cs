using UnityEngine;
using System.Collections;

public class FrogMovement : MonoBehaviour {

	public float jumpElevationInDegrees = 45;
	public float[] jumpSpeedInCMPS = { 200, 400, 700 };
	public float jumpGroundClearance = 200;
	public float jumpSpeedTolerance = 5;

	public int collisionCount = 0;
	public int hopCount = 0;

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter()
	{
		collisionCount++;
	}

	void OnCollisionExit()
	{
		collisionCount--;
	} 

	// Update is called once per frame
	void Update () {
		//bool isOnGround = Physics.Raycast(transform.position, -transform.up, jumpGroundClearance);
		bool isOnGround = collisionCount > 0;

		if (isOnGround)
		{
			hopCount = 0;
		}

		//Debug.DrawRay(transform.position, -transform.up * jumpGroundClearance);
		//var speed = GetComponent<Rigidbody>().velocity.magnitude;
		//bool isNearStationary = speed < jumpSpeedTolerance;

		if ((Input.GetKeyDown(KeyCode.Space) || GvrViewer.Instance.Triggered) && hopCount < jumpSpeedInCMPS.Length)
		{
			var camera = GetComponentInChildren<Camera>(); //Debug.DrawRay(transform.position, camera.transform.forward, Color.green); //Debug.DrawRay(transform.position, jumpVector, Color.green);
			var projectedLookDirection = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up); //Debug.DrawRay(transform.position, projectedLookDirection, Color.blue);
			var radiansToRotate = Mathf.Deg2Rad * jumpElevationInDegrees;
			var unnormalizedJumpDirection = Vector3.RotateTowards(projectedLookDirection, Vector3.up, radiansToRotate, 0);
			var jumpVector = unnormalizedJumpDirection.normalized * jumpSpeedInCMPS[hopCount]; //Debug.DrawRay(transform.position, jumpVector.normalized, Color.red);
			GetComponent<Rigidbody>().AddForce(jumpVector, ForceMode.VelocityChange); // acceleration is the worst change - constant velocity

			hopCount++;
		}
	}
}
