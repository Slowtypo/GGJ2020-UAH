using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    // Start is called before the first frame update
    public float HP1;
    public float HP1Max;
    public float HP2;
    public float HP2Max;
    public float movementSpeed;
    public float movementSpeed2;
    public float Damage;
    public float armor;
    public float armor2;
    public int repairLevel;
    public int repairLevel2;
    public int scraps;
    private int scrapscost;

    public Animator playerAnimate;

    public Text scrapCounter;
    public Text hpCounter;

    [Header("Unity Stuff")]
    public Image healthBar;
    //public GameObject movementInfo;

   


    void Start()
    {
        HP1Max = 100;
        HP2Max = 100;
        Damage = 5;
        repairLevel = 1;
        repairLevel2 = 1;
        movementSpeed = this.GetComponent<PlayerMovement>().runSpeed;
        //movementSpeed2 = this.GetComponent<Playermovement2>().runSpeed;
        armor = 0.2f;
        armor2 = 2f;
        playerAnimate.SetBool("Death", false);


        //audioSourceRepair = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // --- For the upgrade system ---
        scrapCounter.text = "Scraps: " + scraps;
        // For UI Screen--
        hpCounter.text = "" + (int)HP1;
        
        TakeDamageOverTimeP1(Time.deltaTime / 2);
        //TakeDamageOverTimeP2(Time.deltaTime / armor2);

        if (HP1 <= 0)
        {
            HP1 = 0;
        }
        if (scraps <= 0)
        {
            scraps = 0;
        }

        if (Input.GetButtonDown("Jump") )
        {
           

            Invoke("TakeJumpDamageP1", 0.05f);
        }
        

        if (Input.GetButtonDown("Jump2"))
        {


            Invoke("TakeJumpDamageP2", 0.05f);
        }
        
        if (Input.GetButton("Repair"))
        {
            Invoke("RepairDamageP1", 0.1f);
            
                
        }
        else 
        {
            GetComponent<PlayerMovement>().runSpeed = movementSpeed;

            if(HP1 > 0)
            {
                GetComponent<PlayerMovement>().repairing = false;
            }
            
        }

        if (HP1 <= 0)
        {
            GetComponent<PlayerMovement>().runSpeed = 0;
            GetComponent<PlayerMovement>().repairing = true;

            playerAnimate.SetBool("Death", true);

            Debug.Log("PLAYER DEAD");
        }

        /*
        if (Input.GetButton("Repair2"))
        {
            Invoke("RepairDamageP2", 0.1f);
        }
        else
        {
            GetComponent<Playermovement2>().runSpeed = movementSpeed2;

            if (HP2 > 0)
            {
                GetComponent<Playermovement2>().repairing = false;
            }

        }

        if (HP2 <= 0)
        {
            GetComponent<Playermovement2>().runSpeed = 0;
            GetComponent<Playermovement2>().repairing = true;
        }
        */

    }

    public void TakeDamageOverTimeP1 (float amount)
    {
        HP1 -= amount;

        healthBar.fillAmount = HP1/HP1Max ;
    }

    public void TakeDamageOverTimeP2(float amount)
    {
        HP2 -= amount;

        healthBar.fillAmount = HP2 / HP2Max;
    }
    public void TakeJumpDamageP1()
    {
        HP1 -= Damage;

        healthBar.fillAmount = HP1/HP1Max;
    }

    public void TakeJumpDamageP2()
    {
        HP2 -= Damage;

        healthBar.fillAmount = HP2 / HP2Max;
    }
    public void RepairDamageP1()
    {
        if (HP1 <= HP1Max && HP1 > 0)
        {
            HP1 += 0.1f * repairLevel;
        }

        GetComponent<PlayerMovement>().runSpeed = 0;
        GetComponent<PlayerMovement>().repairing = true;


        healthBar.fillAmount = HP1 / HP1Max;

       
    }
    public void RepairDamageP2()
    {
        if (HP2 <= HP2Max && HP2 > 0)
        {
            HP2 += 0.1f * repairLevel2;
        }

        GetComponent<Playermovement2>().runSpeed = 0;
        GetComponent<Playermovement2>().repairing = true;

        healthBar.fillAmount = HP2 / HP2Max;
    }

   // -------------------------------------//

}
