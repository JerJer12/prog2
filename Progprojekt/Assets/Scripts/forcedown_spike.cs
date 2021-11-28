using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcedown_spike : MonoBehaviour
{
    [SerializeField] Transform resetpoint;
    [SerializeField] GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

     void Update()
    {
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("reset"))
        {
            obj.transform.position = resetpoint.transform.position;
        }
        
    }
    */
}
