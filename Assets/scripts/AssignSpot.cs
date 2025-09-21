using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignSpot : MonoBehaviour
{
    public GameObject[] allChildren;
    public GameObject[] followers;
    private bool assigned;
    public int sum;
    [SerializeField]
    private GameObject text;
    public void Assign(GameObject cube)
    {
        if (cube.GetComponent<FollowerBehavior>().available)
        {
            FollowerBehavior _follow = cube.GetComponent<FollowerBehavior>();
            sum = 0;
            assigned = false;
            foreach (GameObject child in allChildren)
            {
                if (child.GetComponent<SpotBehavior>().available == true)
                {
                    if (!assigned && cube.GetComponent<FollowerBehavior>().thrown)
                    {
                        child.GetComponent<SpotBehavior>().available = false;
                        _follow.ChangeTarget(child);
                        _follow.available = false;
                        cube.GetComponent<HealthBehavior>().hittable = true;
                        cube.GetComponent<DetectCollision1>().active = false;
                        assigned = true;
                        sum++;
                    }
                }
                else
                {
                    sum++;
                }
            }
            text.GetComponent<TextBehavior>().TextBehav(sum);
        }
    }

    void FixedUpdate()
    {
        sum = 0;
        foreach (GameObject child in allChildren)
        {
            if (child.GetComponent<SpotBehavior>().available == false)
            {
                sum++;
            }
        }
        text.GetComponent<TextBehavior>().TextBehav(sum);
    }
    public void LoseAllFollowers()
    {
        foreach (GameObject child in followers)
        {
            FollowerBehavior _follow = child.GetComponent<FollowerBehavior>();
            if (_follow.following == true)
            {
                _follow.ResetCube();
                _follow.following = false;
            }
        }
    }
}
