using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<SoundManager>().Play("click_mixdown");
        //script set so sound will play on collision by name
    }
}
