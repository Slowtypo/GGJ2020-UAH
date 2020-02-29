using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    //public InputControls control;
    AudioSource audioSourceRepair;
    public AudioClip Repair;
    public AudioClip KillM;
    public Animator animatorPlayer;

    public WhatMode modeData;
    public Joystick joystick;

    public Collider2D enemyData;




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
    private void Start()
    {
        audioSourceRepair = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (modeData.isGameOnPhone == true)
        {
            horizontalMove = joystick.Horizontal * runSpeed;
        }
        else
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        }
        

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
  
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        if (Input.GetButtonUp("Repair"))
        {
            repairing = false;
            audioSourceRepair.PlayOneShot(Repair, 0.4f);
            //GetComponent<PlayerStats>().hpCounter.color = Color.yellow;
        }
        
        

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire used");
        }
        if (Input.GetButtonDown("Skill"))
        {
            Debug.Log("Skill used");
        }

        animatorPlayer.SetFloat("Speed", Mathf.Abs(horizontalMove));

    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump, repairing);
        
        jump = false;
    }

    /*
     void OnJump ()
    {
        ///jump = true;
    }

    void OnDown()
    {
        //crouch = true;
    }
    void OnRepair()
    {
        //repairing = true;
    }
    void OnShoot()
    {

    }
    void OnSkill()
    {
        repairing = true;
    }
    void OnMove()
    {
        //controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump, repairing);
    }
    void OnMove2()
    {

    }
    */

    public void ButtonMoblieJump()
    {
        
            jump = true;
        
    }

    public void ButtonMoblieRepair()
    {

        repairing = false;
        audioSourceRepair.PlayOneShot(Repair, 0.4f);

        

    }

   // private void OnTriggerStay2D(Collider2D enemyData)
   // {
        //Destroy(GameObject.Find("Enemy1"), 0.2f);
        //audioSourceRepair.PlayOneShot(KillM, 0.3f);
       // Debug.Log("In range");
   // }
}
