using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{


    private void Start()
    {
      
    }

    // Button to restart game
    public void Restart()
    {
        SceneManager.LoadScene("GamePlay_Level 1");
    }
}
