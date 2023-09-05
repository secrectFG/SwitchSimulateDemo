using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class MultiWaySwitchAnimation : MonoBehaviour
{
    [System.Serializable]
    class AngleState
    {
        public float angle;
        public UnityEvent<bool> isOn;
    }


    [SerializeField]
    private Transform axis;//ÖáÐÄ

    [SerializeField]
    //private float moveSpeed = 10f;
    private float animTime = 1f;

    [SerializeField]
    private AngleState[] angleStates;

    

    private int stateIndex = 0;

    AngleState lastState = null;

    bool animating = false;

    public void Trigger()
    {
        if (animating) return;
        StartCoroutine(MoveToAnge(angleStates[stateIndex]));
        stateIndex++;
        stateIndex %= angleStates.Length;
    }

    IEnumerator MoveToAnge(AngleState targetAngleState)
    {
        animating = true;
        if (lastState != null)
        {
            lastState.isOn?.Invoke(false);
        }

        var targetRotation = Quaternion.Euler(targetAngleState.angle, 0, 0);
        var curRotation = axis.localRotation;
        var time = Time.time;
        while(Time.time - time < animTime)
        {
            var passTime = Time.time - time;
            var rotation = Quaternion.Lerp(curRotation, targetRotation, passTime / animTime);
            axis.localRotation = rotation;
            yield return null;
        }

        targetAngleState.isOn?.Invoke(true);
        lastState = targetAngleState;
        animating = false;
    }

    private void OnGUI()
    {
        if (GUILayout.Button("test"))
        {
            Trigger();
        }
    }
}
