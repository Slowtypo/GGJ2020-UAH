using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDeath : MonoBehaviour
{

    public float levelTimer=0;
    public float nextIncreseTime;
    public float periodBetween;
    public Text Timer;


    // Start is called before the first frame update
    void Start()
    {
        levelTimer = 0;
        this.GetComponent<SpawnFloor>().levelSpeed = 0.6f;
        nextIncreseTime = 10 + (int)Random.Range(0, 5f);
        periodBetween = 25f;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //levelTimer += (int)Time.time;
        Timer.text = "Time: " + (int)levelTimer;

    }

    public void levelHarder()
    {
        this.GetComponent<SpawnFloor>().levelSpeed += Random.Range(0.05f, 0.15f);
    }

    public void levelslower()
    {
        
        this.GetComponent<SpawnFloor>().levelSpeed -= 0.2f;
    }

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
          //  this.GetComponent<SpawnFloor>().levelSpeed -= 0.5f;
           // Debug.Log("Slowed level");
       // }

        levelTimer += Time.deltaTime;
        if (levelTimer > nextIncreseTime)
        {
            nextIncreseTime += Mathf.RoundToInt(periodBetween + Random.Range(2f, 6f));
            
            this.GetComponent<SpawnFloor>().levelSpeed += Random.Range(0.1f, 0.3f);
            //levelTimer = 0;
        }

    }

    

}
