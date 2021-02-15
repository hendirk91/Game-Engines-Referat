using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryFollow : MonoBehaviour
{
    [SerializeField] private Transform cameraTarget;
    [SerializeField] private Vector3 offset;


    private void FixedUpdate()
    {
        //transform.position = (charactertarget.transform.TransformPoint(charactertarget.center) + offset);

        transform.position = cameraTarget.position + Vector3.up * offset.y
            + Vector3.ProjectOnPlane(cameraTarget.right, Vector3.up).normalized * offset.x
            + Vector3.ProjectOnPlane(cameraTarget.forward, Vector3.up).normalized * offset.z;
        transform.eulerAngles = new Vector3(0, cameraTarget.eulerAngles.y, 0);
    }
}
