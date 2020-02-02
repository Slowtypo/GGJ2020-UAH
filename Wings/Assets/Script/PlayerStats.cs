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
    public float Damage;
    public float armor;
    public int repairLevel;


    [Header("Unity Stuff")]
    public Image healthBar;
    //public GameObject movementInfo;



    void Start()
    {
        HP1Max = 100;
        HP2Max = 100;
        Damage = 5;
        repairLevel = 1;
        movementSpeed = this.GetComponent<PlayerMovement>().runSpeed;
        armor = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        TakeDamageOverTimeP1(Time.deltaTime / armor);

        if (Input.GetButtonDown("Jump") )
        {
           

            Invoke("TakeJumpDamageP1", 0.05f);
        }

        if (Input.GetButton("Repair"))
        {
            Invoke("RepairDamageP1", 0.1f);
        }else 
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
        }
       
    }

    public void TakeDamageOverTimeP1 (float amount)
    {
        HP1 -= amount;

        healthBar.fillAmount = HP1/HP1Max ;
    }
    public void TakeJumpDamageP1()
    {
        HP1 -= Damage;

        healthBar.fillAmount = HP1/HP1Max;
    }
    public void RepairDamageP1()
    {
       if( HP1 <= HP1Max && HP1 > 0)
        {
            HP1 += 0.1f*repairLevel;
        }
        
        GetComponent<PlayerMovement>().runSpeed = 0;
        GetComponent<PlayerMovement>().repairing = true;

        healthBar.fillAmount = HP1 / HP1Max;
    }
}
