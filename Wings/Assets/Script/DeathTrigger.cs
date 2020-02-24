using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour
{

    public GameObject GameOverUI;
    public GameObject ResetData;
    public GameObject ResetData2;
    public AudioSource Music;
    public GameObject playerT;

    public AudioClip impact;
    public AudioClip restart;
    AudioSource audioSource;

    public GameObject effectDeath;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.CompareTag("Player"))
        {
            //Destroy(GameObject.FindWithTag("Player"));
            Destroy(collision.gameObject, 0.05f);

            GameObject effect = Instantiate(effectDeath) as GameObject;
            
            effect.transform.position = new Vector2(collision.transform.position.x, collision.transform.position.y);

            audioSource.PlayOneShot(impact, 0.5F);
            Debug.Log("Player Died");
            Invoke("Gameover", 0.4f);
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            Destroy(GameObject.Find("Player2"),0.2f);
            Debug.Log("Player2 Died");
        }
    }
    void Start()
    {
        GameOverUI.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restartgame ()
    {
        audioSource.PlayOneShot(restart, 0.7F);
        Time.timeScale = 1f;
        
        SceneManager.LoadScene("MainGameScene");
        GameOverUI.SetActive(false);
        ResetData.GetComponent<SpawnFloor>().levelSpeed = 0.5f;
        ResetData2.GetComponent<TimerDeath>().levelTimer = 0f;
        ResetData2.GetComponent<TimerDeath>().nextIncreseTime = 20f;
        
    }
    
    public void Gameover()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
        //GameisPaused = true;
        Music.Stop();
        //audioSource.PlayOneShot(impact, 0.5F);
    }

    

}
