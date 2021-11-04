using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pausescrn;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pausescrn.gameObject.activeInHierarchy==false)
            {
                pausescrn.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }

            else
            {
                pausescrn.gameObject.SetActive(false);
                Time.timeScale = 1f;
            }
        }
           
        
    }

    public void Resume()
    {
        pausescrn.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    /*public void Settting()
    {

    }
    */

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }


}
