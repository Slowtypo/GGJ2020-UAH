using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement2 : MonoBehaviour
{
    public PlayerController2 controller2;
    //public InputControls control;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    public bool jump = false;
    public bool crouch = false;
    public bool repairing = false;


    /*
    private void Awake()
    {
        control = new InputControls();

        control.Gameplay1.Jump.performed += ctx => Update();
    }
    */
    // Update is called once per frame

    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal2") * runSpeed;

        if (Input.GetButtonDown("Jump2"))
        {
            jump = true;

        }

        if (Input.GetButtonDown("Crouch2"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch2"))
        {
            crouch = false;
        }

        if (Input.GetButtonUp("Repair2"))
        {
            repairing = false;
        }

        if (Input.GetButtonDown("Fire2"))
        {
            Debug.Log("Fire used");
        }
        if (Input.GetButtonDown("Skill2"))
        {
            Debug.Log("Skill used");
        }


    }

    void FixedUpdate()
    {
        // Move our character
        controller2.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump, repairing);

        jump = false;
    }
}
