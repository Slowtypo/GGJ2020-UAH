using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour
{

    public bool isMusicPaused;
    public AudioSource mainMusic;
    public AudioSource soundEffects;
    public int sceneNumber;
    public SaveSlot slot1;


    // Start is called before the first frame update

    void Start()
    {
        //Scene sceneNumber;

        sceneNumber = SceneManager.GetActiveScene().buildIndex;



        if (isMusicPaused == true)
        {
            mainMusic.enabled = false;
            soundEffects.Pause();

        } else
        {
            mainMusic.enabled = true;
            mainMusic.Play();
            soundEffects.UnPause();
        }
    }

    // Update is called once per frame
    void Update()
    {



    }

    public void MuteFlag(bool muteData)
    {

        isMusicPaused = muteData;
    }

    private void OnDestroy()
    {
        isMusicPaused = slot1.saveSlot1;
    }


}
