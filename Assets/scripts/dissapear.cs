using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dissapear : MonoBehaviour
{
    public void ToggleVisability()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        if (rend.enabled)
            rend.enabled = false;
        //uses the renderer to make an object dissapear on a button.
    }
}