using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissapearcollison : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bar"))
        {
            Debug.Log("hit");
            Destroy(other.gameObject);
            //uses the tag and trigger to detect if the right object has collided with it
            //and destroys it
        }
    }
}