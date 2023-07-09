using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStuff : MonoBehaviour
{
    //Starts the game
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    //Quits the game
    public void Quit()
    {
        Application.Quit();
    }

    public void LoadMainMenu() 
    {
        SceneManager.LoadScene(2);
    }

    public void LoadSettingsMenu() 
    {
        SceneManager.LoadScene(4);
    }
        public void Help() 
    {
        SceneManager.LoadScene(3);
    }
}
