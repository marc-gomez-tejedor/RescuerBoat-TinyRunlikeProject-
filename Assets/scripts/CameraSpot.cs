using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpot : MonoBehaviour
{
    [SerializeField]
    private GameObject nextPoint;
    [SerializeField]
    private GameObject lookAt;
    [SerializeField]
    private GameObject camera;

    public void ChangeCameraSpot()
    {
        nextPoint.SetActive(true);
        camera.GetComponent<CameraAnim>().nextPoint = nextPoint;
        camera.GetComponent<CameraAnim>().objectToLook = lookAt;
        gameObject.SetActive(false);
    }

    public void Done()
    {
        CameraController.waiting = false;
    }

}
