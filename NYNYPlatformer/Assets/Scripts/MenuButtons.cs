using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
    
{
    public string Map;
    public string MenuMap;
    public string Level;
    void Update()
    {
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
        PlayerPrefs.SetInt("Health", 3);
        Time.timeScale = 1;
        SceneManager.LoadScene(Map);
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
