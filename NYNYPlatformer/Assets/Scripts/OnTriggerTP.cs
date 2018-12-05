using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnTriggerTP : MonoBehaviour {
    public string Map;
    public GameObject Player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Player.GetComponent<BottleCollect>().bottleCount >=3)
        {
            SceneManager.LoadScene(Map);
        }
    }
}
