using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerBehavior : MonoBehaviour
{
    public GameObject spotToFollow;
    [SerializeField]
    private int velocityZ;
    public GameObject wall;
    public GameObject defaultSpot;
    public bool available;
    private MovementBehavior _mov;
    private HealthBehavior _health;
    public bool thrown;
    public bool following;
    [SerializeField]
    private float timeToRespawn;
    [SerializeField]
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        _mov = GetComponent<MovementBehavior>();
        _health = GetComponent<HealthBehavior>();
        ResetCube();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (thrown)
        {
            _mov.Move(new Vector3(0, 0, 1), velocityZ);
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                ResetCube();
            }
        }
        else
        {
            _mov.LerpTo(spotToFollow.transform.position);
        }
        
    }

    public GameObject GetFollowerId()
    {
        return spotToFollow;
    }

    public void ResetCube()
    {
        _health.health = 1;
        if (spotToFollow.TryGetComponent(out SpotBehavior hlt))
        {
            hlt.available = true;
        }
        _health.hittable = false;
        timer = timeToRespawn;
        thrown = false;
        available = true;
        following = false;
        spotToFollow = defaultSpot;
        _mov.TeleportTo(spotToFollow.transform.position);
    }

    public void FreeCube(Vector3 pos)
    {
        available = true;
        _mov.TeleportTo(pos);
    }

    public void ChangeTarget(GameObject newTarget)
    {
        spotToFollow = newTarget;
        thrown = false;
    }
    public void Throw()
    {
        thrown = true;
        GetComponent<DetectCollision1>().active = true;
    }

    public void GetHit(int dmg)
    {
        if (_health.hittable && !_health.invu && transform.position.z <= 0)
        {
            _health.Hurt(dmg);
        }
    }
}
