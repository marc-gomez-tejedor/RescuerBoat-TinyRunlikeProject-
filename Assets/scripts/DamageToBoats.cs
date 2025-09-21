using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToBoats : MonoBehaviour
{
    public int dmg;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.TryGetComponent(out FollowerBehavior hlt))
        {
            hlt.GetHit(dmg);
        }
        else if (collision.gameObject.TryGetComponent(out ShootAnchor uwu))
        {
            collision.gameObject.GetComponent<HealthBehavior>().Hurt(dmg);
        }
    }
}
