using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObj : MonoBehaviour
{
    public GameObject objectToInstantiate;
    public GameObject destinationPosition;
    public float destX;
    public float destY;
    public float destZ;
    
    public void InstantiateToPosition()
    {
        Instantiate(objectToInstantiate, new Vector3(destX, destY, destZ), Quaternion.identity);
    }

    public void InstantiateToObject()
    {
        Instantiate(objectToInstantiate, destinationPosition.transform.position, Quaternion.identity);
    }
}
