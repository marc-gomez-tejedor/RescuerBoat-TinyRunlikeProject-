using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMov : MonoBehaviour
{
    private MovementBehavior _movement;
    public float velocityX;
    float hor;

    void Start()
    {
        _movement = GetComponent<MovementBehavior>();
    }

    private void Update()
    {
        if (BoatRotation.playing) hor = Input.GetAxis("Horizontal");
        else hor = 0;
    }
    void FixedUpdate()
    {
        _movement.Move(new Vector3(hor, 0, 0), velocityX);
    }
}
