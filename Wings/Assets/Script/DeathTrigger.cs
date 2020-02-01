using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.CompareTag("Player"))
        {
            //Destroy(GameObject.FindWithTag("Player"));
            Destroy(collision.gameObject, 0.2f);
            Debug.Log("Player Died");
            Invoke("Restartgame", 2f);
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            Destroy(GameObject.Find("Player2"),0.2f);
            Debug.Log("Player2 Died");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Restartgame ()
    {
        SceneManager.LoadScene("MainGameScene");
        
    }
}
