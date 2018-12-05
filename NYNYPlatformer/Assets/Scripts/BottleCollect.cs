using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleCollect : MonoBehaviour {
   public int bottleCount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
