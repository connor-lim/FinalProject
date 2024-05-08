using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public AudioSource die;
    public int maxHealth;
    public int currentHealth;

    [SerializeField] private HealthBar healthbar;


    void Awake()
    {
        currentHealth = maxHealth;
        healthbar.updateHealthBar(maxHealth, currentHealth);
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            die.Play();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemyAttack")
        {
            currentHealth -= 10;
            healthbar.updateHealthBar(maxHealth, currentHealth);
        }
        if (other.gameObject.tag == "enemyKatana")
        {
            currentHealth -= 5;
            healthbar.updateHealthBar(maxHealth, currentHealth);
        }

        if (other.gameObject.tag == "enemyKick")
        {
            currentHealth -= 10;
            healthbar.updateHealthBar(maxHealth, currentHealth);
        }
    }
}
