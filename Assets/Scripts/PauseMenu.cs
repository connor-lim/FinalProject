using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public AudioSource buttonPressed;
    public static bool Paused = false;
    public GameObject pauseMenu;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            if (Paused)
            {
                Resume();
            }
            else
            {
                Stop();
            }
        }
    }

    void Stop()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }

    public void Resume()
    {
        buttonPressed.Play();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    public void MainMenuButton()
    {
        buttonPressed.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
    }
}
