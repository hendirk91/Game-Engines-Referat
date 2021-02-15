using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionInputTest : MonoBehaviour
{
    [Space][Header("Input Action Reference")]   [SerializeField] InputActionReference debugActionReference;
    [Space][Header("Input Action")]             [SerializeField] InputAction debugAction;
    [Space][Header("Input Action Property")]    [SerializeField] InputActionProperty debugActionProperty;
    [Space][Header("Input Action Asset")]       [SerializeField] InputActionAsset debugActionAsset;

    

    private void Awake()
    {
        // Using Methods
        debugActionReference.action.started += DebugOnAction;
        debugAction.started += DebugOnAction;

        // Using Lambda Expressions
        debugActionProperty.action.performed += context => Debug.Log(context.ReadValue<Vector2>());
        debugActionProperty.action.canceled += context => Debug.Log("CANCELED: Player Stopped Moving!");

        //debugActionAsset.FindAction("KeyBoardInputTest/MenuDebugger").started 
        //    += context => Debug.Log("Action found in Asset, pressed: " + context.control.name);
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
