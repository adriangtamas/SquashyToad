﻿using UnityEngine;
using System.Collections;

public class FrogMovement : MonoBehaviour {

	public Vector3 jumpVector = new Vector3(0,1,2);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay(transform.position, jumpVector, Color.green);
		var projectedJumpVector = Vector3.ProjectOnPlane(jumpVector, Vector3.up);
		Debug.DrawRay(transform.position, projectedJumpVector, Color.blue);
		var radiansToRotate = Mathf.Deg2Rad * 90;
		var rotatedJumpVector = Vector3.RotateTowards(projectedJumpVector, Vector3.up, radiansToRotate, 0);
		Debug.DrawRay(transform.position, rotatedJumpVector.normalized, Color.red);
		if (Input.GetKeyDown(KeyCode.Space))
		{
			GetComponent<Rigidbody>().AddForce(jumpVector, ForceMode.VelocityChange); // acceleration is the worst change - constant velocity
		}
	}
}