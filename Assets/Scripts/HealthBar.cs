using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image healthbar;

    public void updateHealthBar(float maxHealth, float currentHealth)
    {
        healthbar.fillAmount = currentHealth/maxHealth;
    }
}
