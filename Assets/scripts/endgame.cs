using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
        //uses the trigger to detect a collision
        //see gamemanager script for function.
    }
}
