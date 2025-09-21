using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowCubes : MonoBehaviour
{
    
    public GameObject[] allChildren;
    public bool playing;

    [SerializeField]
    private GameObject defaultSpot;

    [SerializeField]
    private GameObject defaultSpot2;

    private float timer;
    private float cubesAvailable;

    private double randomnum;
    
    [SerializeField]
    private float fixedTime;

    [SerializeField]
    private int range;

    void Start()
    {
        timer = fixedTime;
        playing = true;
    }

    void Update()
    {
        if (timer <= 0 && playing)
        {
            timer = fixedTime;
            cubesAvailable=0;
            foreach (GameObject child in allChildren)
            {
                if (child.GetComponent<FollowerBehavior>().available == true)
                {
                    //Debug.Log("1for each child child:" + child);
                    cubesAvailable++;
                }
            }
            //randomnum = (5 * Random.Range(0, 1) ^ (10) + 1) * 3;
            randomnum = Random.Range(3, range);
            if (randomnum >= cubesAvailable)
            {
                randomnum = cubesAvailable;
            }
            foreach (GameObject child in allChildren)
            {
                //Debug.Log("2for each child child:" + child);
                if (child.GetComponent<FollowerBehavior>().available == true && child.GetComponent<FollowerBehavior>().thrown == false && randomnum > 0)
                {
                    //Debug.Log("random num--: " + randomnum);
                    randomnum--;
                    child.GetComponent<FollowerBehavior>().FreeCube(new Vector3(Random.Range(defaultSpot.transform.position.x, defaultSpot2.transform.position.x), defaultSpot.transform.position.y, Random.Range(-5,5)+defaultSpot.transform.position.z));
                    child.GetComponent<FollowerBehavior>().Throw();
                }
            }
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
    public void StopThrowing()
    {
        playing = false;
    }
}
