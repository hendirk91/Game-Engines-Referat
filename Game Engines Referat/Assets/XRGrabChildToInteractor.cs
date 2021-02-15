using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// Derived XRGrabInteractable that sets the interactor as Parent when selected.
/// </summary>
public class XRGrabChildToInteractor : XRGrabInteractable
{
    //protected override void Awake()
    //{
    //    base.Awake();
    //}

    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        transform.SetParent(interactor.transform);
        base.OnSelectEntered(interactor);
    }

    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        transform.SetParent(null);
        base.OnSelectExited(interactor);
    }
}
