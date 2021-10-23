using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall_obj : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform spawn;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            player.transform.position = spawn.transform.position;
        }
    }

}
