using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PowerCoffee : MonoBehaviour {
    public GameObject Player;
    public float timer;
    public Text PowerUpText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PowerUpText.GetComponent<Text>().text = "Boost left:" + timer;
        if (timer >= 20)
        {
            Player.GetComponent<PlatformerMovement>().moveSpeed = 4;
            Player.GetComponent<PlatformerMovement>().moveSpeed = 2;
        }
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            timer += Time.deltaTime;
            Player.GetComponent<PlatformerMovement>().moveSpeed = 5;
            Player.GetComponent<PlatformerMovement>().moveSpeed = 3;
            Destroy(gameObject);
           
        }
    }
}
