using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBehavior : MonoBehaviour
{
    public int dmg;
    [SerializeField]
    private bool autoDestroy;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.TryGetComponent(out HealthBehavior hlt))
        {
            hlt.Hurt(dmg);
        }
        if (autoDestroy)
        {
            GetComponent<DestroyBehavior>().Destroy();
        }
    }
}