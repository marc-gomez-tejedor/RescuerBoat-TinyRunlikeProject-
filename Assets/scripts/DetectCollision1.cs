using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision1 : MonoBehaviour
{
    public bool active = true;
    private void OnTriggerEnter(Collider collision)
    {
        if (active && collision.gameObject.TryGetComponent(out BoatMov bm))
        {
            GetComponent<FollowerBehavior>().following = true;
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
