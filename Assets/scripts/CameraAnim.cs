using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnim : MonoBehaviour
{
    [SerializeField]
    private float velocity;
    private MovementBehavior _movement;
    public GameObject objectToLook;
    
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
        _movement.Move(dir, velocity);
        transform.LookAt(objectToLook.transform);
    }
}


