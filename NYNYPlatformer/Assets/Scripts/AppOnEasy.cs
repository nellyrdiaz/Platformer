using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppOnEasy : MonoBehaviour {

    public GameObject Player;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<Difficulty>().diff <= 1)
        {
            GetComponent<BoxCollider2D>().enabled = true;
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
