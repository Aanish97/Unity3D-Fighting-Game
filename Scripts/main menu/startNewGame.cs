﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenuOptions : MonoBehaviour {

	public void PlayGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    public void Quit()
    {
        print("QUITING GAME!!!...");
        Application.Quit();
    }
}
