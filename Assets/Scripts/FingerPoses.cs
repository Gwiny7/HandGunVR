using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.XR;

public class FingerPoses : Controller
{
    void Update()
    {
        base.Update();

        // fingerAction[(int)Finger.Index] = Input.GetKey(KeyCode.U) ?  1 : 0;
        // fingerAction[(int)Finger.Middle] = Input.GetKey(KeyCode.I) ?  1 : 0;
        // fingerAction[(int)Finger.Ring] = Input.GetKey(KeyCode.O) ?  1 : 0;
        // fingerAction[(int)Finger.Pinky] = Input.GetKey(KeyCode.P) ?  1 : 0;
        
    }
    
    public void OnIndexFingerUpdate(InputAction.CallbackContext ctx)
    {
        bool inputValue = (bool)ctx.ReadValue<bool>();
        
        fingerAction[(int)Finger.Index] = inputValue ? 1 : 0;
    }
    
    public void OnThreeFingersUpdate(InputAction.CallbackContext ctx)
    {
        bool inputValue = (bool)ctx.ReadValue<bool>();
        
        float f = inputValue ? 1 : 0;
        
        fingerAction[(int)Finger.Middle] = f;
        fingerAction[(int)Finger.Ring] = f;
        fingerAction[(int)Finger.Pinky] = f;
    }
}
