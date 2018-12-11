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
    float timer = 0;
    
    
    

    void Update()
    {
        // make timer for on trigger so you have to wait 1 second.
        HP = PlayerPrefs.GetInt("Health");
        HPText.GetComponent<Text>().text = "Health " + HP;
        timer += Time.deltaTime;
        
    }
    void Start()
    {
     
       //PlayerPrefs.SetInt("health", HP);
        HP = PlayerPrefs.GetInt("Health");
        HPText.GetComponent<Text>().text = "Health: " + HP;

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        // if more than 1 Health minus health
        float yVelocity = GetComponent<Rigidbody2D>().velocity.y;
        if (collision.gameObject.tag == "Enemy" && HP >= 2 && timer >= 1)
        {

            //  HP--;
            timer = 0;
            PlayerPrefs.SetInt("Health", HP - 1);
            Destroy(collision.gameObject);



        }
        if (collision.gameObject.tag == "Health" && HP <= 4)
        {
            PlayerPrefs.SetInt("Health", HP + 1);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Health" && HP >= 5)
        {
            Destroy(collision.gameObject);
                }
        else if (collision.gameObject.tag == "Enemy" && HP <= 1 && yVelocity >= 0)
        {

            SceneManager.LoadScene(GameOver);

        }
    }



        void OnCollisionEnter2D(Collision2D collision)
    {
        // if more than 1 Health minus health
        float yVelocity = GetComponent<Rigidbody2D>().velocity.y;
        if (collision.gameObject.tag == "Enemy" && HP >= 2 && timer >= 1)
        {

          //  HP--;
           
            PlayerPrefs.SetInt("Health", HP - 1);
            
            
        
        }
        if(collision.gameObject.tag == "Health" && HP <=4)
        {
            PlayerPrefs.SetInt("Health", HP + 1);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Health" && HP >=5)
        {
            Destroy(collision.gameObject);
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

    



