using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DontDestroyThisV1 : MonoBehaviour {

	// Use this for initialization
	public string level;
    public string level2;
    public string level3;
    public string level4;
	void Start () {
		DontDestroyOnLoad (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		//when we load the actual game, we need to kill this object
		if (SceneManager.GetActiveScene ().name == level || SceneManager.GetActiveScene().name == level2 || SceneManager.GetActiveScene().name == level3 || SceneManager.GetActiveScene().name == level4) {
			Destroy (this.gameObject);
		}
	}
}
