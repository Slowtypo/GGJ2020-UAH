using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeMenu : MonoBehaviour
{

    public PlayerStats statdata;
    public PlayerMovement buttonsData;
    //public triggerUpgrade platformUpgrade1;
    public CharacterController2D statdata2;
    public SpawnFloor levelData;
    public Canvas upgradeUI;
    public Text scrapWarning;
    public int scrapCost;
    //public GameObject pG;
    
    bool isUIopen;
    bool isUpgrade;
    bool platformInRange;

    // Start is called before the first frame update
    void Start()
    {
        upgradeUI.enabled = false;
        isUIopen = false;
        isUpgrade = buttonsData.openUpgrade;
        //platformInRange = platformUpgrade1.trigger1;
        //platformUpgrade1 = pG.GetComponentInChildren<triggerUpgrade>();
    }

    // Update is called once per frame
    void Update()
    {
        platformInRange = FindObjectOfType<triggerUpgrade>().trigger1;

        if (Input.GetKeyDown(KeyCode.G) && isUIopen == false && platformInRange == true)
        {
             isUIopen = true;
            upgradeUI.enabled = true;
            Time.timeScale = 0f;
            scrapWarning.gameObject.SetActive(false);
            Debug.Log("UpgradeUi");
        }
        else if (Input.GetKeyDown(KeyCode.G) && isUIopen == true)
        {
            isUIopen = false;
            upgradeUI.enabled = false;
            Time.timeScale = 1f;
        }
        //platformUpgrade1.GetComponentInChildren<triggerUpgrade>().trigger1 == true 
        if (buttonsData.openUpgrade == true && platformInRange == true)
        {
            Debug.Log("Upgrade menu 1");
            isUIopen = true;
            upgradeUI.enabled = true;
            Time.timeScale = 0f;
            buttonsData.openUpgrade = false;


        }
    }

    public void ResumeFromUpgrade()
    {
        upgradeUI.enabled = false;
        Time.timeScale = 1f;
        isUpgrade = false;
        scrapWarning.gameObject.SetActive(false);


    }
   public void OpenUpgradeUi()
    {
        upgradeUI.enabled = false;
        Time.timeScale = 1f;
        isUpgrade = false;
        scrapWarning.gameObject.SetActive(false);

    }

    public void RepairCore()
    {
        if (statdata.scraps >= scrapCost && statdata.scraps > 0)
        {
            levelData.cores += 1;
            statdata.scraps -= scrapCost;
            scrapWarning.gameObject.SetActive(false);
            //scrapCost += 1;
            Debug.Log("Core repaired");
        }
        else
        {
            scrapWarning.gameObject.SetActive(true);
            Debug.Log("Core Not repaired");
        }
         
    }
    public void BuySpeed()
    {
        if (statdata.scraps >= scrapCost && statdata.scraps > 0)
        {
            statdata.movementSpeed += 5;
            statdata.scraps -= scrapCost;
            scrapWarning.gameObject.SetActive(false);
        } else
        {
            scrapWarning.gameObject.SetActive(true);
        }
    }
    public void BuyAirJump()
    {
        if (statdata.scraps >= scrapCost && statdata.scraps > 0)
        {
            statdata2.jumpLevel += 1;
            statdata.scraps -= scrapCost;
            scrapWarning.gameObject.SetActive(false);
        }
        else
        {
            scrapWarning.gameObject.SetActive(true);
        }

    }
    public void BuyRecharge()
    {
        if (statdata.scraps >= scrapCost && statdata.scraps > 0)
        {
            statdata.repairLevel += 1;
            statdata.scraps -= scrapCost;
            scrapWarning.gameObject.SetActive(false);
        }
        else
        {
            scrapWarning.gameObject.SetActive(true);
        }

    }
    public void BuySlowHack()
    {
        if (statdata.scraps >= scrapCost && statdata.scraps > 0)
        {
            levelData.levelSpeed -= 0.2f;
            statdata.scraps -= scrapCost;
            scrapWarning.gameObject.SetActive(false);
        }
        else
        {
            scrapWarning.gameObject.SetActive(true);
        }

    }
}
