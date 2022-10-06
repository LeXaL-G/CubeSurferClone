using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.tag == "Player")
    //         Time.timeScale = 0;
    // }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MainCube")
            Time.timeScale = 0;
    }
}
