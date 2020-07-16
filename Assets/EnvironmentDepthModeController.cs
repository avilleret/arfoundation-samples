using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class EnvironmentDepthModeController : MonoBehaviour
{
    AROcclusionManager occlusionManager;

    void Awake()
    {
        occlusionManager = FindObjectOfType<AROcclusionManager>();
    }

    public void OnDropdownValueChanged(int val)
    {
        switch(val)
        {
            default:
            case 0:
              occlusionManager.requestedEnvironmentDepthMode = EnvironmentDepthMode.Disabled;
              break;
            case 1:
              occlusionManager.requestedEnvironmentDepthMode = EnvironmentDepthMode.Fastest;
              break;
            case 2:
              occlusionManager.requestedEnvironmentDepthMode = EnvironmentDepthMode.Medium;
              break;
            case 3:
              occlusionManager.requestedEnvironmentDepthMode = EnvironmentDepthMode.Best;
              break;
        }

    }
}
