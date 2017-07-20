﻿using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {

	public GameObject prefab;

	public float meanTime = 4;
	public float minTime = 2;
	float nextSpawnTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Time.time > nextSpawnTime)
		{
			Spawn();
			//nextSpawnTime = Time.time + Random.Range(spawnIntervalMin, spawnIntervalMax);
			nextSpawnTime = Time.time + minTime - Mathf.Log(Random.value) * meanTime;
		}
	}

	void Spawn()
	{
		var instance = Instantiate(prefab, transform.position, transform.rotation, transform);
	}
}
