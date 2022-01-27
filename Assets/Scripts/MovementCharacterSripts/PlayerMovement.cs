using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;
    public float MovementSpeed = 30;
    public Vector3 externalForce;
    

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // player movement - forward, backwards, left, right
        float horizontal = Input.GetAxis("Horizontal") * MovementSpeed;
        float vertical = Input.GetAxis("Vertical") * MovementSpeed;
        characterController.Move((Vector3.right * horizontal + Vector3.forward * vertical + externalForce) * Time.deltaTime);

        //Gravity

    }

}
