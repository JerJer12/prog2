using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private bool jumpKeyWasPressed;
    private float horizontelInput;
    private Rigidbody rigidbodyComp;
    [SerializeField]private Transform groundCheck;         //így is lehetne --> public Transform groundCheck;   
    [SerializeField] AudioSource jumpsound;
    [SerializeField] AudioSource EnemyDeathSound;
   


    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComp = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed=true;
        }

        horizontelInput = Input.GetAxis("Horizontal");

    }


    // FixedUpdate is called once per every physic update
    private void FixedUpdate() 
    {
        rigidbodyComp.velocity = new Vector3(horizontelInput*4, rigidbodyComp.velocity.y, 0);

        if (Physics.OverlapSphere(groundCheck.position, 0.1f).Length == 1)
        {
            return;
        }

         if(jumpKeyWasPressed)
        {
            rigidbodyComp.AddForce(Vector3.up * 7, ForceMode.VelocityChange);
            jumpsound.Play();
            jumpKeyWasPressed = false;

        }

         
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy head"))
            {
            Destroy(other.transform.parent.gameObject);
            EnemyDeathSound.Play();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("bouncepad"))
        {
            rigidbodyComp.AddForce(Vector3.up * 14, ForceMode.VelocityChange);
        }
    }




}
