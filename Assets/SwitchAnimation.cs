using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnimation : MonoBehaviour
{
    public float StartAngle = 0;
    public float EndAngle = 60;
    public float Speed = 1;
    
    public void PlayOff()
    {
        StopAllCoroutines();
        StartCoroutine(PlayOffCo());
    }

    public void PlayOn()
    {
        StopAllCoroutines();
        StartCoroutine(PlayOnCo());
    }

    IEnumerator PlayOffCo()
    {
        //x轴从StartAngle到EndAngle的动画
        float angle = transform.transform.localEulerAngles.x;
        while (angle < EndAngle)
        {
            angle = Mathf.MoveTowardsAngle(angle, EndAngle, Time.deltaTime * Speed);
            transform.transform.localEulerAngles = new Vector3(angle,0,0);
            yield return null;
        }
    }

    IEnumerator PlayOnCo()
    {
        float angle = transform.transform.localEulerAngles.x;
        while (angle > StartAngle)
        {
            angle = Mathf.MoveTowardsAngle(angle, StartAngle, Time.deltaTime * Speed);
            transform.transform.localEulerAngles = new Vector3(angle, 0, 0);
            yield return null;
        }
    }
}
