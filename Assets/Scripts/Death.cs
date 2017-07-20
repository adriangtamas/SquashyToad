using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	public GameObject UICanvas;
	public GameObject Reticule;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnDeath()
	{
		UICanvas.SetActive(true);
		Reticule.SetActive(true);
		GetComponent<Rigidbody>().isKinematic = true;
	}
}
