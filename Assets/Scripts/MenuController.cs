using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject screen1;
    public GameObject screen2;
    public void exit()
    {
        Application.Quit();
    }
    public void open_screens()
    {
        if (screen1.activeSelf)
        {
            screen1.SetActive(false);
            screen2.SetActive(true);
        }
        else
        {
            screen1.SetActive(true);
            screen2.SetActive(false);
        }
        
    }

    public void load_game()
    {      
        SceneManager.LoadScene("Level1");
    }

    public void load_lvl1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void load_lvl2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void load_lvl32()
    {
        SceneManager.LoadScene("Level3");
    }
}
