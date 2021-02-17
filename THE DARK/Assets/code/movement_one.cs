using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class movement_one : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 2.0f;
    [SerializeField]
    private float rotationspeed = 280.0f;
    //check if move or not
    private bool checkmove = false;
    private Player playerinput;
    private Vector3 movement;
    private float Vertical, horizontal;

    public Animator anim;

    //private Vector3 curLoc;
    //private Vector3 prevLoc;
    private void Awake()
    {
        playerinput = new Player();
    }
    private void OnEnable()
    {
        playerinput.player_one.Enable();
        playerinput.player_one.move.performed += onmove;
        playerinput.player_one.move.canceled += onmoveexit;
    }

    private void onmoveexit(InputAction.CallbackContext obj)
    {
        Vector2 moveinput = obj.ReadValue<Vector2>();
        Vertical = moveinput.y;
        horizontal = moveinput.x;
        checkmove = false;
        anim.SetBool("walk", false);
    }

    private void onmove(InputAction.CallbackContext obj)
    {
        Vector2 moveinput = obj.ReadValue<Vector2>();
        Vertical = moveinput.y;
        horizontal = moveinput.x;
        checkmove = true;
        anim.SetBool("walk",true);

    }

    private void OnDisable()
    {
        playerinput.Disable();
    }
    void Start()
    {
        
    }

    void Update()
    {
        //Vector2 input = playerinput.player_one.move.ReadValue<Vector2>();
        //Vector3 move = new Vector3(input.x, 0f, input.y);
        ////.Move(move * Time.deltaTime * playerSpeed);
        if (checkmove == true)
        {
            // move
            Vector3 movedirection = Vector3.forward * Vertical + Vector3.right * horizontal;
           
            //move with cam
            Vector3 projectedcam = Vector3.ProjectOnPlane(Camera.main.transform.forward, Vector3.up);
            Quaternion rotationcam = Quaternion.LookRotation(projectedcam, Vector3.up);
            movedirection = rotationcam * movedirection;
            //move with input
            movement = movedirection * playerSpeed * Time.deltaTime;
            transform.position += movement;
           
            //transform.Translate(movedirection * playerSpeed * Time.deltaTime,Space.World);
            //transform.rotation = Quaternion.LookRotation(movement);

            //rotate player with movement
            if (movedirection != Vector3.zero)
            {
                //transform.rotation = Quaternion.LookRotation(movedirection);
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movedirection.normalized),0.05f);
                //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(transform.position - prevLoc), Time.fixedDeltaTime * rotationspeed);

            }
        }

    }
}
