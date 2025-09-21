using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField]
    private float velocity;
    private MovementBehavior _movement;

    public GameObject nextPoint;
    private Vector3 dir;

    void Start()
    {
        _movement = GetComponent<MovementBehavior>();
    }

    private void Update()
    {
        dir = nextPoint.transform.position - transform.position;
    }
    void FixedUpdate()
    {
        _movement.LerpTo(nextPoint.transform.position,velocity);

    }
}
