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
        positionOfObj01 = new Vector3(-5.0f, 7.2f, 13.1f);
        rotationOfObj01 = new Vector3( 22.9f,180.1f, 0.0f);

        positionOfObj02 = new Vector3(-21.3f, 7.2f, 0.5f);
        rotationOfObj02 = new Vector3(22.9f, 90.0f, 0.0f);

        positionOfObj03 = new Vector3(-5.1f, 7.2f, -13.6f);
        rotationOfObj03 = new Vector3(22.9f, 0.0f, 0.0f);

        positionOfObj04 = new Vector3(11.2f, 7.2f, -0.4f);
        rotationOfObj04 = new Vector3(22.9f,270.0f, 0.0f);

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

        //positionOfObj01 = cam.transform.localPosition;
        //rotationOfObj01 = cam.transform.localEulerAngles;
        //Debug.Log(positionOfObj01);
        //Debug.Log(rotationOfObj01);

    }

    void Update()
    {
        
        if(cam_input.camera.cammove.triggered)
        {
            if(camnum==1)
            {
                transform.localPosition = positionOfObj02;
                transform.localEulerAngles = rotationOfObj02;
                camnum = 2;
            }
            else if(camnum == 2)
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
