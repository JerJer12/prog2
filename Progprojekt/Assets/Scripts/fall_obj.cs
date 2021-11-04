using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall_obj : MonoBehaviour
{
    [SerializeField] private Transform obj;
    [SerializeField] private Transform spawn;

    private void OnTriggerEnter(Collider other)
    {
        obj.transform.position = spawn.transform.position;
    }

}
