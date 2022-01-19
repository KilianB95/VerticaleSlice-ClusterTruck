using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    public Rigidbody rb;
    public float forceAmount = 20;
    private GameObject TruckPlaceHodler;
    

    
    void Start()
    {
        //rb.AddForce(Vector3.forward * forceAmount, ForceMode.Acceleration);
        
    }

    void FixedUpdate()
    {
        rb.AddForce(Vector3.forward * forceAmount, ForceMode.Acceleration);

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag ==  "TurnZone" )
        {
            TruckPlaceHodler.transform.Rotate(30f, 0f, 0f);
        }
    }


}
