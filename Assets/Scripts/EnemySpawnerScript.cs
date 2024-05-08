using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    public Transform hitBox;

    private Vector3 center;
    private Vector3 size;

    void Awake()
    {
        center = new Vector3(hitBox.position.x /2, 1, hitBox.position.z/2);
        size = new Vector3(120,1,120);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            int randomNum = Random.Range(1,5);
            for (int i = 0; i < randomNum; i++)
            {
                Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 1, Random.Range(-size.z / 2, size.z / 2));
                int randomEnemy = Random.Range(0,3);
                if (randomEnemy == 0){
                    Instantiate(enemy1, pos,Quaternion.identity);
                }
                if (randomEnemy == 1){
                    Instantiate(enemy2, pos,Quaternion.identity);
                }
                if (randomEnemy == 2){
                    Instantiate(enemy3, pos,Quaternion.identity);
                }
            }
        }
    }


}
