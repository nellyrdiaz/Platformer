using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BottleCollect : MonoBehaviour {
   public int bottleCount;
    public Text Bottles;
	// Use this for initialization
	void Start () {
        Bottles.GetComponent<Text>().text = "Bottles:" + bottleCount;
    }
	
	// Update is called once per frame
	void Update () {
        Bottles.GetComponent<Text>().text = "Bottles:" + bottleCount;
	}
     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bottles")
        {
            bottleCount++;
            Debug.Log("Bottles" + bottleCount);
            Destroy(collision.gameObject);
        }
    }
}
