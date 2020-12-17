using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetGame : MonoBehaviour
{
    public void ResetLevel ()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //resets the level to know u have completed it
    }
}
