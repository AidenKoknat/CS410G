using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{
    private float Speed = 4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        // Move horizontal
        //body.AddForce(new Vector2(Speed, 0));
        transform.Translate(new Vector2(Speed, 0));
    }
}