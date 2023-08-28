using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchDetector : MonoBehaviour
{
    public UnityEvent<bool> OnSwitch;

    private void OnTriggerEnter(Collider other)
    {
        OnSwitch?.Invoke(true);
    }

    private void OnTriggerExit(Collider other)
    {
        OnSwitch?.Invoke(false);
    }
}
