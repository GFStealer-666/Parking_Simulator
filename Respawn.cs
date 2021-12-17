using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    Vector3 Respawnpoint;

    private void Start()
    {
        Respawnpoint = new Vector3(47.74f, 0, 74.49f);
    }

    void FixedUpdate()
    {
        if (transform.position.y < -1)
        {
            transform.position = Respawnpoint;
          /*  GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;*/
        }
            
    }
}

