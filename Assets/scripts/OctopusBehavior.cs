using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctopusBehavior : MonoBehaviour
{
    [SerializeField]
    private float velx;
    private int direction;
    private MovementBehavior _movement;

    void Start()
    {
        direction = 1;
        _movement = GetComponent<MovementBehavior>();
    }

    void FixedUpdate()
    {
        _movement.Move(new Vector3(direction, 0, 0), velx);
    }

    public void SwapDirection()
    {
        direction *= -1;
    }
}
