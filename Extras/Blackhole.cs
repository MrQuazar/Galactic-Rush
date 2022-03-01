using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Blackhole : MonoBehaviour
{
    public GameObject player;
    public GameObject VictoryScreenCanvas = null;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            VictoryScreenCanvas.SetActive(true);
            player.SetActive(false);
        }

    }
}
