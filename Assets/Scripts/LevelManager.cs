using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
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

	public void Quit()
	{
		print("Game will quit");
		Application.Quit();
	}
}
