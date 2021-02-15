using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorInteractable : XRBaseInteractable
{

    protected override void Awake()
    {
        base.Awake();
        selectEntered.AddListener(Grab);
    }

    private void Grab(SelectEnterEventArgs args)
    {
        transform.position = new Vector3(0, args.interactor.transform.position.y, 0);
    }

    protected override void OnDestroy()
    {
        selectEntered.RemoveListener(Grab);
    }

}
