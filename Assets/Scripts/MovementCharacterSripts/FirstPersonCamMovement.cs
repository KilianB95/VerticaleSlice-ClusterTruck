using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamMovement : MonoBehaviour
{
    public float HorizontalSpeed = 1f;
    public float verticaleSpeed = 1f;
    private float xRotation = 0.1f;
    private float yRotation = 0.1f;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * HorizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticaleSpeed;

        yRotation += mouseX;
        xRotation -= xRotation = Mathf.Clamp(xRotation, -90, 90);
        cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);
    }
}
