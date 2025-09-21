using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseCanvas;
    private bool screenActive;
    [SerializeField]
    private GameObject smokeScreen;
    [SerializeField]
    private float fixedTime;
    private float timer;

    public void ActivateSmoke()
    {
        smokeScreen.SetActive(true);
        screenActive = true;
        timer = fixedTime;
    }

    public void DesactivateSmoke()
    {
        smokeScreen.SetActive(false);
        screenActive = false;
    }
    void Update()
    {
        if (timer <= 0)
        {
            if (screenActive)
            {
                DesactivateSmoke();
            }
        }
        else timer -= Time.deltaTime;
    }
    public void Pause()
    {
        pauseCanvas.SetActive(true);
        gamePaused = true;
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseCanvas.SetActive(false);
        gamePaused = false;
        Time.timeScale = 1f;
        GetComponent<EventCaller>().CallEvent();
    }
}
