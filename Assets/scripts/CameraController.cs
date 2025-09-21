using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static float velocityX;
    public static bool waiting;
    private MovementBehavior _movement;
    
    void Start()
    {
        velocityX = -20;
        waiting = true;
        _movement = GetComponent<MovementBehavior>();
    }

    void FixedUpdate()
    {
        if (!waiting) _movement.Move(new Vector3(0, 0, 1), velocityX);
    }

    public void slowWorld()
    {
        velocityX = -15;
    }
    public void slowWorld2()
    {
        velocityX = -10;
    }
    public void slowWorld3()
    {
        velocityX = -5;
    }
    public void slowWorld4()
    {
        velocityX = 0;
    }
}
