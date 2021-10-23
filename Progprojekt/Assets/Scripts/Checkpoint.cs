using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Transform pos1;
    [SerializeField] private Transform pos2;
    [SerializeField] private Transform pos3;
    [SerializeField] private Transform player;
    private int checkpointCount = 1;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody R = player.GetComponent<Rigidbody>();
        if (other.gameObject.tag == "checkpoint")
        {
            BoxCollider BC = other.gameObject.GetComponent<BoxCollider>();
            BC.enabled = false;
            checkpointCount++;
        }
        if (other.gameObject.tag == "respawn")
        {
            if (checkpointCount == 2)
            {
                player.transform.position = pos2.transform.position;
            }

            else if (checkpointCount == 3)
            {

                player.transform.position = pos3.transform.position;
               
            }
            else
            {
                player.transform.position = pos1.transform.position;
               
            }
        }
    }
}
