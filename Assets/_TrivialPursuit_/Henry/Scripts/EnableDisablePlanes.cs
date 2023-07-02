using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class EnableDisablePlanes : MonoBehaviour
{
    [SerializeField] ARPlaneManager planeManager;

    

    public void TogglePlanes()
    {
        foreach (var plane in planeManager.trackables)
        {
            if (plane.isActiveAndEnabled == true)
            {
                plane.gameObject.SetActive(false);
            }
            else if (plane.isActiveAndEnabled == false)
            {
                plane.gameObject.SetActive(true);
            }
        }
    }

    public void TogglePlanes(bool status)
    {
        foreach (var plane in planeManager.trackables)
            plane.gameObject.SetActive(status);
    }
}
