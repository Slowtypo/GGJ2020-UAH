using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerUpgrade : MonoBehaviour
{
    public bool trigger1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            trigger1 = true;
            
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            trigger1 = false;

        }
    }


}
