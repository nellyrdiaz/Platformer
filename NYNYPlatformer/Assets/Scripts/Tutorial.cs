using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {
    float timerMove;
    float timerJump;
    public GameObject MoveCanvas;
    public GameObject JumpCanvas;
    bool JumpCanvasOn = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timerMove += Time.deltaTime;
        if(timerMove >=2)
        {
            MoveCanvas.SetActive(false);
        }
        if (JumpCanvasOn)
        {
            timerJump += Time.deltaTime;
        }
        if (timerJump >= 2)
        {
            JumpCanvas.SetActive(false);
        }
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == ("Tutorial"))
        {
            MoveCanvas.SetActive(false);
            JumpCanvas.SetActive(true);

            JumpCanvasOn = true;
            Destroy(collision.gameObject);
        }
    }
}
