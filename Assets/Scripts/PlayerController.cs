﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{

    void FixedUpdate()
    {   
        //Speed of movement forwards, backwords and rotation left right
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 10.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}

