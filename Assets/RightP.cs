﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightP : MonoBehaviour
{
    public float scaler = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(0, Input.GetAxis("RightP"), 0) * scaler;

    }
}
