using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
