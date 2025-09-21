using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSpot : MonoBehaviour
{
    public GameObject spotToFollow;
    public MovementBehavior _mov;
    // Start is called before the first frame update
    void Start()
    {
        _mov = GetComponent<MovementBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        _mov.LerpTo(spotToFollow.transform.position);
    }

    public GameObject GetFollowerId()
    {
        return spotToFollow;
    }
}
