using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMenu : MonoBehaviour
{

    public PlayerStats statdata;
    public CharacterController2D statdata2;
    public SpawnFloor levelData;
    public Canvas upgradeUI;

    public int scrapCost;
    bool isUIopen;

    // Start is called before the first frame update
    void Start()
    {
        upgradeUI.enabled = false;
        isUIopen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.G) && isUIopen == false)
        {
             isUIopen = true;
            upgradeUI.enabled = true;
            Time.timeScale = 0f;
        }else if (Input.GetKeyDown(KeyCode.G) && isUIopen == true)
        {
            isUIopen = false;
            upgradeUI.enabled = false;
            Time.timeScale = 1f;
        }
    }

    public void ResumeFromUpgrade()
    {
        upgradeUI.enabled = false;
        Time.timeScale = 1f;
        
    }

    public void RepairCore()
    {
        if (statdata.scraps <= scrapCost && statdata.scraps > 0)
        {
            statdata.armor2 += 1;
            statdata.scraps -= scrapCost;
        }
         
    }
    public void BuySpeed()
    {
        if (statdata.scraps <= scrapCost && statdata.scraps > 0)
            statdata.movementSpeed += 1;
        statdata.scraps -= scrapCost;
    }
    public void BuyAirJump()
    {
        if (statdata.scraps <= scrapCost && statdata.scraps > 0)
            statdata2.jumpLevel += 1;
        statdata.scraps -= scrapCost;
    }
    public void BuyRecharge()
    {
        if (statdata.scraps <= scrapCost && statdata.scraps > 0)
        {
            statdata.repairLevel += 1;
            statdata.scraps -= scrapCost;
        }
            
    }
    public void BuySlowHack()
    {
        if (statdata.scraps <= scrapCost && statdata.scraps > 0)
        {
            levelData.levelSpeed -= 1;
            statdata.scraps -= scrapCost;
        }
            
    }
}
