using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnchor : MonoBehaviour
{
    private MovementBehavior _movement;
    public float velocity;
    void Start()
    {
        _movement = GetComponent<MovementBehavior>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _movement.Move(new Vector3(0, 0, 1), velocity);
    }
}
