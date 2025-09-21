using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
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
}
