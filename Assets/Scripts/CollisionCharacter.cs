using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCharacter : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            Destroy(this.gameObject);
        }
    }
}
