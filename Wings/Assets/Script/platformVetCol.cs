using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformVetCol : MonoBehaviour
{
    private PlatformEffector2D effector1;
    private float waitTime;

    private void Start()
    {
        effector1 = GetComponent<PlatformEffector2D>();

    }

    private void Update()
    {
        if (Input.GetButtonUp("Crouch"))
        {
            waitTime = 0.5f;
            Debug.Log("Player let go of down key!");
            effector1.rotationalOffset = 0;
        }

        if (Input.GetButton("Crouch"))
        {
            if(waitTime <= 0)
            {
                effector1.rotationalOffset = 180f;
                waitTime = 0.5f;
               
            }else 
            {
                waitTime -= Time.deltaTime;
            }
        }

        if (Input.GetButton("Jump"))
        {
            effector1.rotationalOffset = 0;
        }
    }
}
