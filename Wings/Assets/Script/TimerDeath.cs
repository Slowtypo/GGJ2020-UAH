﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDeath : MonoBehaviour
{

    public float levelTimer=0;
    public float nextIncreseTime;
    public float periodBetween;
    // Start is called before the first frame update
    void Start()
    {
        levelTimer = 0;
        this.GetComponent<SpawnFloor>().levelSpeed = 1;
        nextIncreseTime = 10;
        periodBetween = 20f;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //levelTimer += (int)Time.time;
        

    }

    public void levelHarder()
    {
        this.GetComponent<SpawnFloor>().levelSpeed += Random.Range(0.1f, 0.2f);
    }

    public void levelslower()
    {
        
        this.GetComponent<SpawnFloor>().levelSpeed -= 0.2f;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.GetComponent<SpawnFloor>().levelSpeed -= 0.2f;
            Debug.Log("Slowed level");
        }

        levelTimer += Time.deltaTime;
        if (levelTimer > nextIncreseTime)
        {
            nextIncreseTime += Mathf.RoundToInt(periodBetween + Random.Range(1f, 10f));
            // execute block of code here
            this.GetComponent<SpawnFloor>().levelSpeed += Random.Range(0.05f, 0.2f);
            //levelTimer = 0;
        }

    }

    

}
