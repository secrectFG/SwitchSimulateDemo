using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Switch : MonoBehaviour
{
    public bool IsOn = false;

    public UnityEvent<bool> SwitchEvent;

    public void Trigger(bool isOn)
    {
        IsOn = isOn;
        SwitchEvent?.Invoke(isOn);
    }
}
