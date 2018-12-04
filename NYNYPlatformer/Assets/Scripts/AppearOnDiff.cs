using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearOnDiff : MonoBehaviour {
    public GameObject Player;

    // Use this for initialization
    void Start()
    {

    }
	// Update is called once per frame
	void Update () {
        if (Player.GetComponent<Difficulty>().diff >= 2)
        {
            GetComponent<BoxCollider2D>().enabled = true;
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
