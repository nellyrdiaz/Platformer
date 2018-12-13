using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyThis : MonoBehaviour {

	// Use this for initialization
	public string level;
	void Start () {
		var test = GameObject.Find ("OldGameMusic");
		if (test != null) {
			Destroy (this.gameObject);
		} else {
			DontDestroyOnLoad (this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.name != "OldGameMusic") {
			this.gameObject.name = "OldGameMusic";
		}
		//when we load the actual game, we need to kill this object
		if (SceneManager.GetActiveScene ().name == level) {
			Destroy (this.gameObject);
		}
	} 
}
