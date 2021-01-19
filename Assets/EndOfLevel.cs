using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndOfLevel : MonoBehaviour
{

    public void endOfGame()
    {
        //Debug.Log("HIT");
        //Application.Quit();
        SceneManager.LoadScene("fps");
    }
}
