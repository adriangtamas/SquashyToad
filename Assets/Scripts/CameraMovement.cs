using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("Parent");
		print(transform);
		Camera camera = GetComponentInChildren<Camera>();
		print("Camera transform");
		print(camera.transform);
	}
	
	// Update is called once per frame
	void Update () {
		float rotationSpeed = 5.0f;
		float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
		float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
		transform.localRotation = Quaternion.Euler(0, mouseX, 0) * transform.localRotation;
		Camera camera = GetComponentInChildren<Camera>();
		camera.transform.localRotation = Quaternion.Euler(-mouseY, 0, 0) * camera.transform.localRotation;
	}
}
