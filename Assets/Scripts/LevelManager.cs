﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadNextScene()
	{
		//Load Scene
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		// Load currentIndex + 1
		SceneManager.LoadScene(currentIndex + 1);
	}

	public void ReloadScene()
	{
		//Load Scene
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentIndex);
	}

	public void Quit()
	{
		print("Game will quit");
		Application.Quit();
	}
}
