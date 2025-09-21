using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAnchor : MonoBehaviour
{
    public float timer;
    [SerializeField]
    private float fixedTime;
    [SerializeField]
    private GameObject anchor;
    
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Shoot();
                RestartTimer();
            }
        }        
    }
    void RestartTimer()
    {
        timer = fixedTime;
    }
    void Shoot()
    {
        GameObject anchorI = GameObject.Instantiate(anchor);
        anchorI.transform.position = anchor.transform.position;
        anchorI.SetActive(true);
    }
}
