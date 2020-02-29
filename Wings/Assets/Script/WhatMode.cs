using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatMode : MonoBehaviour

    
{
    public bool isGameOnPhone = false;
    public Canvas phoneButtons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOnPhone == true)
        {
            phoneButtons.gameObject.SetActive(true);

        }else
        {
            phoneButtons.gameObject.SetActive(false);
        }
    }
}
