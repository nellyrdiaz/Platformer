﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cheats : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Street");
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene("Hotel");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("Apartment");
        }
    }
}
