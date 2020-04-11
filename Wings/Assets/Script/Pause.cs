using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public static bool GameisPaused = false;
    public AudioMixer mixer1;
    float volumeNumber;
    

    public GameObject pauseMenuUI;
    public GameObject muteB;
    public GameObject unmuteB;


    private void Start()
    {
        mixer1.GetFloat("volume", out volumeNumber);

        Debug.Log("Volume is on at: "+ volumeNumber);



       if (volumeNumber == -80)
        {
            unmuteB.SetActive(true);
            muteB.SetActive(false);

        }
        else
        {
            unmuteB.SetActive(false);
            muteB.SetActive(true);
        }
    }
    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape) || Input.GetButtonDown("Cancel"))
        {
            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause1();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }
    public void Pause1()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    public void StopMusic1()
    {
        mixer1.SetFloat("volume", -80);
    }

    public void PlayMusic1()
    {
        mixer1.SetFloat("volume", 0);
    }


    //pauseMenuUI.SetActive(false;)

}
