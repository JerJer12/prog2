using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMoving : MonoBehaviour
{
    public GameObject Player;
    public GameObject Endscrn;
    public GameObject Camera;

    private void OnTriggerEnter(Collider other)
    {
        if(Endscrn.activeInHierarchy==true)
        {
            Camera.transform.parent = null;
            Player.SetActive(false);
        }
    }
}
