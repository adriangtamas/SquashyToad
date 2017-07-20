using UnityEngine;
using System.Collections;

public class HUDRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Camera camera = transform.parent.GetComponentInChildren<Camera>();
		//Vector3 cameraForward = camera.transform.forward;
		var projectedLookDirection = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up);
		transform.rotation = Quaternion.LookRotation(projectedLookDirection);
	}
}
