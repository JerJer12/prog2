using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullscreen : MonoBehaviour
{
    public void fullscreen(bool full)
    {
        Screen.fullScreen = full;
        Debug.Log("Fullscreen is" + full);
    }
}
