using UnityEngine;
using System.Collections;

public class Lethal : MonoBehaviour {

	Death deathComponent;

	// Use this for initialization
	void Start () {
		deathComponent = FindObjectOfType<Death>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		deathComponent.OnDeath();
	}
}
