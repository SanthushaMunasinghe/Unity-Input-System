using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestingInputSystem : MonoBehaviour
{
    public void Jump(InputAction.CallbackContext ctx)
    {
        Debug.Log(ctx);
        //if (ctx.performed)
        //{
        //    Debug.Log("Jump " + ctx.phase);
        //}
    }
}
