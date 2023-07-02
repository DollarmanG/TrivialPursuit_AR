using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARTapToPlace : MonoBehaviour
{
    [SerializeField]
    private GameObject refToPrefab;

    [SerializeField]
    private ARRaycastManager raycastManager;

    [SerializeField]
    private ConjureKitManager conjureKitManager;

    [SerializeField]
    private EnableDisablePlanes enableDisablePlanes;

    private static List<ARRaycastHit> hitResults = new List<ARRaycastHit>();

    private GameObject spawnedObject;

    private bool qrButtonPressed = false;

    bool TryGetTouchPosition(out Vector2 touchPos)
    {
        if (Input.touchCount > 0)
        {
            touchPos = Input.GetTouch(0).position;

            return true;
        }

        touchPos = default;

        return false;
    }

    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 touchPos))
        {
            return;
        }

        if (raycastManager.Raycast(touchPos, hitResults, TrackableType.Planes) && qrButtonPressed)
        {
            Pose hitPose = hitResults[0].pose;

            if (spawnedObject == null)
            {
                spawnedObject = Instantiate(refToPrefab, hitPose.position, hitPose.rotation);
                conjureKitManager.CreateSphereEntity(spawnedObject);
                enableDisablePlanes.TogglePlanes(false);
            }
            //else
            //{
            //    spawnedObject.transform.position = hitPose.position;
            //    spawnedObject.transform.rotation = hitPose.rotation;
            //}
        }
    }

    public void ToggleQRButtonPressed()
    {
        qrButtonPressed = !qrButtonPressed;
    }
}