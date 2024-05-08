using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnerManager : MonoBehaviour
{
    public GameObject shrine;
    public GameObject spawner;

    public AudioSource wind;

    public int count;

    void Awake()
    {
        wind.Play();
    }

    public void Update()
    {
        bool isShrine = (GameObject.FindWithTag("chest"));
        {
            if (!isShrine)
            {
                Destroy(spawner);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
        }
    }

}
