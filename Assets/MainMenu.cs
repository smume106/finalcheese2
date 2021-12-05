using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Replay()
    {
        GameObject.Find("Timer").SendMessage("Restart");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 0);

    }

    public void Exit()
    {
        Application.Quit();
    }
}