using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public Switch Switch;
    public SwitchAnimation SwitchAnimation;


    private void OnMouseDown()
    {
        //Debug.Log("Switch.IsOn:" + Switch.IsOn);
        if (Switch.IsOn)
        {
            SwitchAnimation.PlayOff();
            Debug.Log("PlayOff");
        }
        else
        {
            SwitchAnimation.PlayOn();
            Debug.Log("PlayOn");
        }
    }
}
