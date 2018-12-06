using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PowerCoffee : MonoBehaviour {
    public GameObject Player;
    public float timer;
    public Text PowerUpText;
    public Slider PowerUpSlider;
    bool timerStart = false;
    public GameObject PowerUpSliderApp;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timerStart)
        {
            timer -= Time.deltaTime;
            PowerUpText.GetComponent<Text>().text = "Boost left:" + timer;
            PowerUpSlider.GetComponent<Slider>().value = timer;
            if (timer <= 0)
            {
                Player.GetComponent<PlatformerMovement>().moveSpeed = 4;
                Player.GetComponent<PlatformerMovement>().jumpSpeed = 7;
                timerStart = false;
                timer = 20;
               
                PowerUpText.GetComponent<Text>().enabled = false;
                PowerUpSliderApp.SetActive(false);
              
            }
        }
        
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           
            PowerUpText.GetComponent<Text>().enabled = true;
            PowerUpSliderApp.SetActive(true);
            timer = 20;
            timerStart = true;
            Player.GetComponent<PlatformerMovement>().moveSpeed = 5;
            Debug.Log("Hi");
            Player.GetComponent<PlatformerMovement>().jumpSpeed = 8;
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
           
        }
    }
}
