using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationControls : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update ()
    {
          //   else if (Player.GetComponent<PlatformerMovement>().JumpBool == true)
         if (  GetComponent<PlatformerMovement>().grounded == false)
        {
            GetComponent<Animator>().SetBool("Jump", true);
            GetComponent<Animator>().SetFloat("X", 0);
            GetComponent<Animator>().SetBool("Idle", false);
        }
        else if (Input.GetAxis("Horizontal") != 0)
        {
            float x = Input.GetAxis("Horizontal");
            GetComponent<Animator>().SetFloat("X", x);
            GetComponent<Animator>().SetBool("Idle", false);
            GetComponent<Animator>().SetBool("Jump", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("Idle", true);
            GetComponent<Animator>().SetFloat("X", 0);
            GetComponent<Animator>().SetBool("Jump", false);
        }
       
        }

    }

