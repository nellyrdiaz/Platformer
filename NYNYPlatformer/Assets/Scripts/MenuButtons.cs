using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
    
{
    public string Map;
    public string MenuMap;
    public string Level;
    public GameObject Menu1;
    public GameObject Menu2;
    public GameObject Player;
    int diffhealth =5;
     void Start()
    {
        //PlayerPrefs.SetInt("difficultyhealth", diffhealth);
        diffhealth = PlayerPrefs.GetInt("difficultyhealth");
    }

    void Update()
    {
        diffhealth = PlayerPrefs.GetInt("difficultyhealth");
        // check to see if p key is pressed
        if (Input.GetKeyDown(KeyCode.P))
        {

            //if is pressed stop stuff from moving
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                //make pause menu visible
                GetComponent<Canvas>().enabled = true;
            }
            else if (Time.timeScale == 0)
            {
                //unpause
                Resume();
            }
        }
    }

    public void NewGame()
    {
       
        PlayerPrefs.SetInt("Health", diffhealth);
        Time.timeScale = 1;
        SceneManager.LoadScene(Map);
    }
    public void DiffMenu()
    {
        Menu1.SetActive(false);
        Menu2.SetActive(true);
    }
    public void Hard()
    {
        PlayerPrefs.SetInt("difficultyhealth", 3);
        
        Player.GetComponent<Difficulty>().diff = 2;
        PlayerPrefs.SetInt("Difficulty", 2);
        Menu2.SetActive(false);
        Menu1.SetActive(true);
       
    }
    public void Easy()
    {
        PlayerPrefs.SetInt("difficultyhealth", 5);
        Player.GetComponent<Difficulty>().diff = 1;
        PlayerPrefs.SetInt("Difficulty", 1);
        Menu2.SetActive(false);
        Menu1.SetActive(true);
    
    }
    public void SwitchLevel()
    {
        SceneManager.LoadScene(Level);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Resume()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;

    }
    public void Menu()
    {
        SceneManager.LoadScene(MenuMap);
    }

}
