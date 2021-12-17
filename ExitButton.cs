using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public GameObject ExitBUtton;

    public bool Active = false;

    public void Update()
    {
       /* if (Active == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ExitBUtton.SetActive(true);
                Active = true;
            }
        }
            
        if(Active == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ExitBUtton.SetActive(false);
                Active = false;
            }
        }*/
           

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
