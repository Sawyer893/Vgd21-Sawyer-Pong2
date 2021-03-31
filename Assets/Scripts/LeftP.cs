using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftP : MonoBehaviour
{
    public float scaler = 0.3f;
    private float paddleMotion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, paddleMotion, 0);
        float yPos = Mathf.Clamp(transform.position.y, -3.0f, 3.0f);
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);

    }
}
