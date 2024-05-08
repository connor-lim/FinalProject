using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRunnerScript : MonoBehaviour
{

    public GameObject enemyObject;

    // Update is called once per frame
    void Update()
    {
        if (enemyObject.activeInHierarchy)
        {
            //Debug.Log("It is active");
        }
        else
        {
            Debug.Log("Game Over");
        }
    }
}
