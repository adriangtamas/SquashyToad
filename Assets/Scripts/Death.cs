using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	public GameObject UICanvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnDeath()
	{
		UICanvas.SetActive(true);
	}
}
