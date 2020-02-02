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
    public int movementSpeed;
    public int skills;

    [Header("Unity Stuff")]
    public Image healthBar;



    void Start()
    {
        HP1Max = 100;
        HP2Max = 100;
    }

    // Update is called once per frame
    void Update()
    {
        TakeDamageOverTimeP1(Time.deltaTime / 2);

        if (Input.GetButtonDown("Jump") )
        {
           

            Invoke("TakeJumpDamageP1", 0.1f);
        }
    }

    public void TakeDamageOverTimeP1 (float amount)
    {
        HP1 -= amount;

        healthBar.fillAmount = HP1/HP1Max ;
    }
    public void TakeJumpDamageP1()
    {
        HP1 -= 10;

        healthBar.fillAmount = HP1 / HP1Max;
    }
}
