using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnTruck : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Truck")
        {
            Debug.Log("On Truck");
            //Player.transform.position = new Vector3(collision.transform.position.x, Player.transform.position.y, collision.transform.position.z);
            Player.transform.parent = collision.transform;
        }
    }

   
}
