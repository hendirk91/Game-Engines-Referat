using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorInteractable : XRBaseInteractable
{

    protected override void Awake()
    {
        base.Awake();
        onSelectEntered.AddListener(Grab);
    }

    private void Grab(XRBaseInteractor interactor)
    {
        transform.position = new Vector3(0, interactor.transform.position.y, 0);
    }

    protected override void OnDestroy()
    {
        onSelectEntered.RemoveListener(Grab);
    }

}
