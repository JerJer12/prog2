using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTele : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = teleportTarget.transform.position;
    }
}