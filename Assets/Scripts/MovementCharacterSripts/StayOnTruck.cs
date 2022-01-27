using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnTruck : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Truck")
        {
            Debug.Log("On Truck");
            Player.transform.parent = collision.transform;
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
