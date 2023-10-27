using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]

public class CameraOffsetAdjustment : MonoBehaviour
{
    void Start() {
        var localCamera = GetComponent<Camera>();
        localCamera.stereoTargetEye = StereoTargetEyeMask.None;
    }
}
