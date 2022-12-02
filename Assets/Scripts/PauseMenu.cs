using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused;
    public GameObject btnPause;
    public GameObject uiPauseMenu;
    public AudioSource Audio;

    public void Pause()
    {
        btnPause.SetActive(false);
        uiPauseMenu.SetActive(true);
        isPaused = true;
        Time.timeScale = 0;
        Audio.Pause();
    }

    public void Resume()
    {
        uiPauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
        btnPause.SetActive(true);
        Audio.UnPause();
    }

    
}
