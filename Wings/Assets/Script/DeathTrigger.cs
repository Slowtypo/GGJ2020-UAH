using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour
{

    public GameObject GameOverUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.CompareTag("Player"))
        {
            //Destroy(GameObject.FindWithTag("Player"));
            Destroy(collision.gameObject, 0.3f);
            Debug.Log("Player Died");
            Invoke("Gameover", 0.5f);
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            Destroy(GameObject.Find("Player2"),0.3f);
            Debug.Log("Player2 Died");
        }
    }
    void Start()
    {
        GameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restartgame ()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainGameScene");
        GameOverUI.SetActive(false);
    }

    public void Gameover()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
        //GameisPaused = true;
    }
}
