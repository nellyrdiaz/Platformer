using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int HP = 3;
    public Text HPText;
    public string GameOver;
   
    
    
    

    void Update()
    {
        HPText.GetComponent<Text>().text = "Health " + HP;
        
    }
    void Start()
    {
     
       //PlayerPrefs.SetInt("health", HP);
        HP = PlayerPrefs.GetInt("Health");
        HPText.GetComponent<Text>().text = "Health: " + HP;

    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        // if more than 1 Health minus health
        float yVelocity = GetComponent<Rigidbody2D>().velocity.y;
        if (collision.gameObject.tag == "Enemy" && HP >= 2 && yVelocity >=0)
        {

            HP--;
           
            PlayerPrefs.SetInt("Health", HP - 1);

          
            
            
            
        
        }
        // if less than 1 Health lose screen
       else if (collision.gameObject.tag == "Enemy" && HP <= 1 && yVelocity >= 0)
        {

            SceneManager.LoadScene(GameOver);
          
        }

   
       
    }
    public void ModifyPlayerHP(int mod)
    {
        PlayerPrefs.SetInt("Health", HP + 1);
        HP += mod;
    }
}

    



