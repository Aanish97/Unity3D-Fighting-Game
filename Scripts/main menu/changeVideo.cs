using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeVideo : MonoBehaviour {

    // Use this for initialization
    public void changeVideor()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
