using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatRotation : MonoBehaviour
{
    public float rotationSpeed;
    float hor;
    public static bool playing;

    void Start()
    {
        playing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playing) hor = Input.GetAxis("Horizontal");
        else hor = 0;

        Vector3 movementDirection = new Vector3(hor * 0.35f, 1);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }

    public void stop()
    {
        playing = false;
    }

    public void start()
    {
        playing = true;
    }
}
