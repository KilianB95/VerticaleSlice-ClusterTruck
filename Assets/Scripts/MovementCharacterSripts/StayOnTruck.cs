using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnTruck : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
      if (other.gameObject.tag == "Truck")
      {
            transform.parent = other.transform;
      }  
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Truck")
        {
            transform.parent = null;
        }
    }
}
