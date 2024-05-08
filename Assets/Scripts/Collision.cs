using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            print("hit");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            print("stop hit");
        }
    }
}
