using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public bool active=true;
    private void OnTriggerEnter(Collider collision)
    {
        if (active)
        {
            GetComponent<EventCaller>().CallEvent();
        }  
    }
    public void activeTrue()
    {
        active = true;
    }

    public void activeFalse()
    {
        active = false;
    }
}
