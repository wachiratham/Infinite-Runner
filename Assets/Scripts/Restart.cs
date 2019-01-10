﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Level");
    }
    
    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}