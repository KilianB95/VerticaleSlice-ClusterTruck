using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnTruck : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "Truck")
        {
            Debug.Log("On Truck");
            Player.transform.parent = other.transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Truck")
        {
            Debug.Log("fuck");
            Player.transform.parent = null;
        }
    }
}
