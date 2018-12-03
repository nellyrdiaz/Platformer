using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour {
    public Text TimerText;
     public float timer = 120;
    public string Map;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        TimerText.GetComponent<Text>().text = "" + timer;
        
        if (timer <= 0)
        {
            SceneManager.LoadScene(Map);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            timer = 5;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            GetComponent<Timer>().enabled = false;
        }
	}
}
