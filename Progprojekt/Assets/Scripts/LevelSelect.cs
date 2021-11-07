using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Lev1()
    {
        SceneManager.LoadScene(1);
    }

    public void Lev2()
    {
        SceneManager.LoadScene(2);
    }

    public void Lev3()
    {
        SceneManager.LoadScene(3);
    }

    public void Lev4()
    {
        SceneManager.LoadScene(4);
    }
}
