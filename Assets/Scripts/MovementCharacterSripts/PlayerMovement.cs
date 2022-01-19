using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;
    public float MovementSpeed = 15;
    public float Gravity = 9.8f;
    private float velocity = 0;
    public float Jumpforce = 3;
    public bool isGrounded;
    [SerializeField] private Rigidbody rb;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            Debug.Log("weck");
        }
    }

    private void Update()
    {
        // player movement - forward, backwards, left, right
        float horizontal = Input.GetAxis("Horizontal") * MovementSpeed;
        float vertical = Input.GetAxis("Vertical") * MovementSpeed;
        characterController.Move((Vector3.right * horizontal + Vector3.forward * vertical) * Time.deltaTime);

        //Gravity

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, Jumpforce), ForceMode.Impulse);
            Debug.Log("spatie werkt");
           
        }
       
    }

   
}
