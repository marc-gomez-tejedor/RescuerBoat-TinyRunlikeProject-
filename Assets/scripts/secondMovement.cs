using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondMovement : MonoBehaviour
{
    public static float velocityX;
    private MovementBehavior _movement;

    void Start()
    {
        velocityX = -5;
        _movement = GetComponent<MovementBehavior>();
    }

    void FixedUpdate()
    {
        _movement.Move(new Vector3(0, 0, 1), velocityX);
    }
}
