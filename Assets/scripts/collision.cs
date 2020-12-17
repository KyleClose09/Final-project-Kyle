using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("grate"))
        {
            Debug.Log("hit");
            Destroy(other.gameObject);
            //uses the tag and trigger to detect if the right object has collided with it
            //and destroys it
        }
    }
}
