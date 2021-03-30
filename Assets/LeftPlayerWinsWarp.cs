using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftPlayerWinsWarp : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Lscore > 11)
        { 

            Debug.Log("Switch scene");
            SceneManager.LoadScene("LeftWinsScene");
        }
    }
  
}
