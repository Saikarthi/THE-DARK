using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class camera_rotate : MonoBehaviour
{
    
    private Camera cam;


    private Player cam_input;

    private int camnum;

    private Vector3 positionOfObj01;
    private Vector3 rotationOfObj01;
    private Vector3 positionOfObj02;
    private Vector3 rotationOfObj02;
    private Vector3 positionOfObj03;
    private Vector3 rotationOfObj03;
    private Vector3 positionOfObj04;
    private Vector3 rotationOfObj04;

    private void Awake()
    {
        cam = Camera.main;
        positionOfObj01 = new Vector3(-0.8f, 15.8f, 16.3f);
        rotationOfObj01 = new Vector3(22.0f, 180.1f, 0.0f);

        positionOfObj02 = new Vector3(-22.3f, 14.6f, -1.5f);
        rotationOfObj02 = new Vector3(28.8f, 89.0f, 359.8f);

        positionOfObj03 = new Vector3(-1.0f, 16.7f, -16.9f);
        rotationOfObj03 = new Vector3(28.9f, 359.7f, 359.8f);

        positionOfObj04 = new Vector3(23.6f, 17.8f, -1.6f);
        rotationOfObj04 = new Vector3(22.4f, 270.1f, 359.8f);

        cam_input = new Player();
    }
    private void OnEnable()
    {
        cam_input.camera.Enable();
    }



    private void OnDisable()
    {
        cam_input.Disable();
    }
    void Start()
    {
        transform.localPosition = positionOfObj01;
        transform.localEulerAngles = rotationOfObj01;
        camnum = 1;

        // to take the value

        positionOfObj01 = cam.transform.localPosition;
        rotationOfObj01 = cam.transform.localEulerAngles;
        Debug.Log(positionOfObj01);
        Debug.Log(rotationOfObj01);

    }

    void Update()
    {

        if (cam_input.camera.cammove.triggered)
        {
            if (camnum == 1)
            {
                transform.localPosition = positionOfObj02;
                transform.localEulerAngles = rotationOfObj02;
                camnum = 2;
            }
            else if (camnum == 2)
            {
                transform.localPosition = positionOfObj03;
                transform.localEulerAngles = rotationOfObj03;
                camnum = 3;
            }
            else if (camnum == 3)
            {
                transform.localPosition = positionOfObj04;
                transform.localEulerAngles = rotationOfObj04;
                camnum = 4;
            }
            else if (camnum == 4)
            {
                transform.localPosition = positionOfObj01;
                transform.localEulerAngles = rotationOfObj01;
                camnum = 1;
            }
        }
    }
}
