using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text Scoreboard;
    public GameObject ball;

    private int PaddleLeft = 0;
    private int PaddleRIght = 0;


    // Use this for initialization
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 17f)
        {
            PaddleLeft++;

            if (transform.position.y <= -17f)
            {
                PaddleLeft++;
            }

        }

        Scoreboard.text = PaddleLeft.ToString() + " - " + PaddleRIght.ToString();

        print (PaddleLeft + " , " + PaddleRIght);

    }
}