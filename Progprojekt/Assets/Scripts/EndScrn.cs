using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScrn : MonoBehaviour
{
    public GameObject Endscrn;
    public GameObject Player;
    public GameObject Counter;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject== Player)
        {
            Endscrn.gameObject.SetActive(true);
            Counter.gameObject.SetActive(false);

        }
    }
}
