using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestingInputSystem : MonoBehaviour
{
    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    public void ChangeToUI()
    {
        playerInput.SwitchCurrentActionMap("UI");
    }
    
    public void ChangeToPlayer()
    {
        playerInput.SwitchCurrentActionMap("Player");
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        //Debug.Log(ctx);
        if (ctx.performed)
        {
            Debug.Log("Jump " + ctx.phase);
        }
    }
    
    public void Submit(InputAction.CallbackContext ctx)
    {
        //Debug.Log(ctx);
        if (ctx.performed)
        {
            Debug.Log("Submit " + ctx.phase);
        }
    }
}
