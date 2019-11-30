using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startNewGame : MonoBehaviour {

	// Use this for initialization
	public void PlayGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
