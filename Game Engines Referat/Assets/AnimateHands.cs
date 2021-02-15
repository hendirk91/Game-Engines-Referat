using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using UnityEngine.InputSystem;

public class AnimateHands : MonoBehaviour
{
    [SerializeField] private InputActionReference gripAction;
    [SerializeField] private InputActionReference triggerAction;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetFloat("Grip", gripAction.action.ReadValue<float>());
        if(gripAction.action.ReadValue<float>() > 0.1f)
        {
            //Debug.Log(gripAction.action.ReadValue<float>());
        }
        //animator.SetFloat("Trigger", triggerAction.action.ReadValue<float>());
    }
}
