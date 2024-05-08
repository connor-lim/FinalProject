using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    public AudioSource breakBox;
    public int enemyHealth = 100;
    public GameObject damageText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "katana")
        {
            if (this.gameObject.tag == "chest")
            {
                breakBox.Play();
            }
            int damage = 15;
            enemyHealth -= damage;
            DamageIndicator indicator = Instantiate(damageText, transform.position, Quaternion.identity).GetComponent<DamageIndicator>();
            indicator.SetDamageText(damage);
            if (enemyHealth <= 0)
            {
                Destroy(gameObject, 0.3f);
            }
        }

        if (other.gameObject.tag == "katana2")
        {
            if (this.gameObject.tag == "chest")
            {
                breakBox.Play();
            }
            int damage = 30;
            enemyHealth -= damage;
            DamageIndicator indicator = Instantiate(damageText, transform.position, Quaternion.identity).GetComponent<DamageIndicator>();
            indicator.SetDamageText(damage);
            if (enemyHealth <= 0)
            {
                Destroy(gameObject, 0.3f);
            }
        }
    }
}
