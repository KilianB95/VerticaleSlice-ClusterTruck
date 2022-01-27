using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnZone : MonoBehaviour
{
    public float speed = 5f;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Truck")
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
