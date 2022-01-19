using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;
    public float MovementSpeed = 15;
    public float Gravity = 1.0f;
    public float Jumpforce = 0.5f;
    public Vector3 jump;
     bool isGrounded = true;
    [SerializeField] private Rigidbody rb;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 0.0f, 0.0f);
    }
    // detecteert of je op de grond staat
    private void OnCollisionStay(Collision collision)
    {
        
            isGrounded = true;
            Debug.Log(isGrounded);
        
    }

    private void Update()
    {
        // player movement - forward, backwards, left, right
        float horizontal = Input.GetAxis("Horizontal") * MovementSpeed;
        float vertical = Input.GetAxis("Vertical") * MovementSpeed;
        characterController.Move((Vector3.right * horizontal + Vector3.forward * vertical + jump) * Time.deltaTime);


        //Gravity



        // player jump - to jump up 
        
        if (Input.GetKey(KeyCode.Space))
        {
            
            rb.AddForce(jump * Jumpforce, ForceMode.Impulse);
            jump = new Vector3(0.0f, 1.0f, 0.0f);
            isGrounded = false;
            

            Debug.Log(KeyCode.Space);
            
           
        }
        
       
    }

   
}
