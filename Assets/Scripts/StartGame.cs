using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject startMenu;

    public AudioSource wind;
    public AudioSource buttonPressed;

    void Start()
    {
        startMenu.SetActive(true);
        wind.Play();
    }

    public void PlayAbout()
    {
        buttonPressed.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void PlayMain()
    {
        buttonPressed.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
    }

    public void Quit()
    {
        buttonPressed.Play();
        Application.Quit();
    }

    public void MainMenuWin()
    {
        buttonPressed.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-3);
    }

    public void MainMenuLose()
    {
        buttonPressed.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-4);
    }

    public void About()
    {
        buttonPressed.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void MainMenu()
    {
        buttonPressed.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
}
