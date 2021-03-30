using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Right : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Rscore > 11)
        {

            Debug.Log("Switch scene");
            SceneManager.LoadScene("RightWinsScene");
        }
    }

}
