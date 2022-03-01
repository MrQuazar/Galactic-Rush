using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeUi : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject life1UI;
    public GameObject life2UI;
    public GameObject life3UI;
    public GameObject player;
    private int lives;
    void Update()
    {


        if (player == null)
        {
            life1UI.SetActive(false);
            life2UI.SetActive(false);
            life3UI.SetActive(false);
        }
        else
        {
            lives = player.GetComponent<Health>().currentLives;
            if (lives == 1) life2UI.SetActive(false);
            if (lives == 2) life3UI.SetActive(false);
        }

    }

}
