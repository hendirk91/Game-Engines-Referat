using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// Derived XRGrabInteractable that sets the interactor as Parent when selected.
/// </summary>
public class XRGrabChildToInteractor : XRGrabInteractable
{
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        transform.SetParent(args.interactor.transform);
    }

    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        base.OnSelectExited(interactor);
        transform.SetParent(null);
    }

    //protected override void OnSelectExiting(SelectExitEventArgs args)
    //{
    //    base.OnSelectExited(args);
    //    transform.SetParent(null);
    //}
}
