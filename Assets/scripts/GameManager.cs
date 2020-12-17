using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasEnded = false;

    public GameObject completelevelUI;  

    public void CompleteLevel ()
    {
        completelevelUI.SetActive(true);
        //was originally intended for a UI to display a message after game was over
        //couldnt get the ui to render in the headset.
    }

    public void EndGame ()
    {
        if (gamehasEnded == false)
        {
            gamehasEnded = true;
            Debug.Log("GameOver");
            //used to close and restart the game when the time ran out 
            //didnt have enough time to set it up thou
        }
    }
}

