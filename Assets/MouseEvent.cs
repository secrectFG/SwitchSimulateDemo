using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvent : MonoBehaviour
{
    public UnityEvent OnMouseDownEvent;
    private void OnMouseDown()
    {
        OnMouseDownEvent?.Invoke();
    }
}
