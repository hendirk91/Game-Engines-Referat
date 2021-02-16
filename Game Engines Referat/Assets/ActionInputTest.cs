using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionInputTest : MonoBehaviour
{
    [Space][Header("Input Action Reference")]   [SerializeField] InputActionReference debugActionReference;
    [Space][Header("Input Action")]             [SerializeField] InputAction debugAction;

    // Hat Editor Option um zwischen ActionReference und Action zu wählen
    [Space][Header("Input Action Property")]    [SerializeField] InputActionProperty debugActionProperty;

    

    private void Awake()
    {
        // Using Methods
        debugActionReference.action.started += DebugOnAction;
        debugAction.started += DebugOnAction;

        // Using Lambda Expressions
        debugActionProperty.action.started += context => Debug.Log("Player Pressed Key:" + context.control.name);

        //debugActionProperty.action.performed += context => Debug.Log(context.ReadValue<Vector2>());
        //debugActionProperty.action.canceled += context => Debug.Log("CANCELED: Player Stopped Moving!");
    }

    private void DebugOnAction(InputAction.CallbackContext ctx) 
    {
        Debug.Log(ctx.control.name);
    }

    // Input Actions müssen immer erst enabled werden, bevor sie verwendet werden können
    private void OnEnable()
    {
        debugActionReference.action.Enable();
        debugAction.Enable();
    }

    private void OnDisable()
    {
        debugActionReference.action.Disable();
        debugAction.Disable();
    }
}
