using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    private Vector3 _direction;
    private float _velocity;

    public void Init(Vector3 dir, float vel)
    {
        _direction = dir;
        _velocity = vel;
    }

    public void Move()
    {
        transform.position = transform.position + _direction * _velocity;
    }
    public void Move(Vector3 direction, float velocity)
    {
        transform.position +=  direction * velocity * Time.deltaTime;
    }

    public void Move(Vector3 position)
    {
        transform.position += position;
    }

    public void MoveTo(float x, float y)
    {
        transform.position = new Vector3(x, y, transform.position.z);
    }

    public void LerpTo(Vector3 to)
    {
        transform.position = Vector3.Lerp(transform.position, to, Time.deltaTime*6);
    }

    public void LerpTo(Vector3 to, float speed)
    {
        transform.position = Vector3.Lerp(transform.position, to, Time.deltaTime * speed);
    }
    public void LerpX(Vector3 to, float speed)
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, to.x, Time.deltaTime * speed), transform.position.y, transform.position.z);
    }

    public void TeleportTo(Vector3 to)
    {
        transform.position = to;
    }
}
