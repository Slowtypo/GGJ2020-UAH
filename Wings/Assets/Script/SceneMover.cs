using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class SceneMover : MonoBehaviour
{

    public GameObject ResetData;
    public AudioSource Music2;
   
    public AudioClip restart2;
    AudioSource audioSource1;

    //public Pause pauseData;


    private void Start()
    {
        audioSource1 = GetComponent<AudioSource>();
    }
    public void MovetoMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        Music2.Stop();
        audioSource1.PlayOneShot(restart2);
    }

    public void MovetoGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        ResetData.GetComponent<SpawnFloor>().levelSpeed = 0.5f;
        audioSource1.PlayOneShot(restart2);

    }

    public void MovetoQuit()
    {
        Application.Quit();
        //SceneManager.LoadScene(2);
        //Time.timeScale = 1f;
    }

    public void MovetoStory()
    {
        SceneManager.LoadScene(3);
        Music2.Stop();
    }

    public void Update()
    {
        if (Input.GetButtonDown("Quit") && Time.timeScale == 0f )
        {
            MovetoMenu();
            Music2.Stop();
        }
        /*
        if (Input.GetButtonDown("Cancel") && Time.timeScale == 0f && Pause.GameisPaused == false)
        {
            MovetoGame();
        }*/

    }
}
