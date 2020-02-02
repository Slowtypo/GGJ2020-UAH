using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour
{
    public void MovetoMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void MovetoGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void MovetoGameMuit()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }

    public void MovetoStory()
    {
        SceneManager.LoadScene(3);
    }
}
