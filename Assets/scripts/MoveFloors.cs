using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloors : MonoBehaviour
{
    [SerializeField]
    private GameObject previousFloor;
    [SerializeField]
    private GameObject previousFloorFinalPoint;

    [SerializeField]
    private GameObject finalPoint;
    [SerializeField]
    private GameObject closestPoint;
    private float platformWidth;
   
    void Start()
    {
        platformWidth = finalPoint.transform.position.z - closestPoint.transform.position.z;
    }

    // Update is called once per frame
    public void MovePlatform()
    {
        transform.position = new Vector3(previousFloor.transform.position.x, previousFloor.transform.position.y, previousFloorFinalPoint.transform.position.z+platformWidth/2);
    }
}
