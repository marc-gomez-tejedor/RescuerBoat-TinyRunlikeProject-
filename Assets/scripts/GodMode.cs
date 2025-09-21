using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodMode : MonoBehaviour
{
    [SerializeField]
    private GameObject[] followers;
    [SerializeField]
    private GameObject followersObj;
    [SerializeField]
    private bool invuOFFON;
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            foreach (GameObject child in followers)
            {
                FollowerBehavior _follow = child.GetComponent<FollowerBehavior>();
                if (_follow.following == false)
                {
                    _follow.available = true;
                    _follow.thrown = true;
                    followersObj.GetComponent<AssignSpot>().Assign(child);
                    _follow.following = true;
                    break;
                }
            }
        }
        else if (Input.GetKeyDown("s"))
        {
            foreach (GameObject child in followers)
            {
                FollowerBehavior _follow = child.GetComponent<FollowerBehavior>();
                if (_follow.following == true)
                {
                    _follow.ResetCube();
                    _follow.following = false;
                    break;
                }                
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManagement.PlayLevel1();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManagement.PlayLevel2();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManagement.PlayLevel3();
        }

        if (Input.GetKeyDown("i"))
        {
            if (invuOFFON)
            {
                invuOFFON = false;
                foreach (GameObject child in followers)
                {
                    child.GetComponent<HealthBehavior>().invu = false;
                }
            }
            else
            {
                invuOFFON = true;
                foreach (GameObject child in followers)
                {
                    child.GetComponent<HealthBehavior>().invu = true;
                }
            }
        }
    }
}
