using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class WinCondition : MonoBehaviour
{
    public int numSeguidores;
    public GameObject Followers;

    public UnityEvent winEvent;
    public UnityEvent loseEvent;
    public void CheckWin()
    {
        if (Followers.GetComponent<AssignSpot>().sum >= numSeguidores)
        {
            winEvent.Invoke();
        }
        else
        {
            loseEvent.Invoke();
        }
    }
}
