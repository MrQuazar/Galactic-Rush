using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public UIManager uiManager = null;
    public GameObject gameMusic = null;
    public GameObject ContinueScreenCanvas = null;
    public GameObject BlackHole = null;
    public GameObject projectileHolder = null;

    // Start is called before the first frame update

    public void ContinuePressed()
    {
        if (uiManager != null)
        {
            ContinueScreenCanvas.SetActive(false);
            Destroy(GameObject.FindWithTag("Enemy"));
            Destroy(projectileHolder);
            gameMusic.SetActive(true);
            Time.timeScale = 1;
            BlackHole.SetActive(true);
            uiManager.allowPause = false;
        }
    }
}
