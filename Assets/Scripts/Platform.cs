using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Rigidbody>().velocity.y <= 0)
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 800f);
        }
    }
}
