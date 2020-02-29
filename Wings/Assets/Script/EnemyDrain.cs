using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDrain : MonoBehaviour
{
    public PlayerStats playerStatsHere;
   // public SpriteRenderer parentColor;
    // Start is called before the first frame update
    void Start()
    {
        playerStatsHere = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            playerStatsHere.HP1 -= 0.15f;
            playerStatsHere.hpCounter.color = Color.black;
            
            Debug.Log("Damage to player");
        }
        else
        {
            playerStatsHere.hpCounter.color = Color.white;
            Debug.Log("No Damage");
        }

    }
}
