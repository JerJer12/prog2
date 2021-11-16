using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pausescrn;
    [SerializeField] GameObject settings;
    [SerializeField] GameObject Endscrn;
    [SerializeField] GameObject paused;

    // Update is called once per frame
    void Update()
    {
        if (Endscrn.gameObject.activeInHierarchy == false)
        {

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (pausescrn.gameObject.activeInHierarchy == false)
                {
                    pausescrn.gameObject.SetActive(true);
                    Time.timeScale = 0f;
                    settings.gameObject.SetActive(false);
                    paused.gameObject.SetActive(true);
                }

                else
                {
                    pausescrn.gameObject.SetActive(false);
                    Time.timeScale = 1f;
                    settings.gameObject.SetActive(false);
                }
            }
        }
           
        
    }

    public void Resume()
    {
        pausescrn.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    /*public void Setting()
    {

    }
    */

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }


}
