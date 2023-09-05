using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField]
    private float onIntensity = 2;

    [SerializeField]
    private float offIntensity = 0;

    [SerializeField]
    private Color emissionColor;
    Material material;
    private void Start()
    {
        material = GetComponent<MeshRenderer>().material;
        emissionColor = material.GetColor("_EmissionColor");
        SetLight(false);
    }

    public void SetLight(bool isOn)
    {
        if (isOn)
        {
            Color finalColor = emissionColor * Mathf.LinearToGammaSpace(onIntensity);
            material.SetColor("_EmissionColor", finalColor);
        }
        else
        {
            Color finalColor = emissionColor * Mathf.LinearToGammaSpace(offIntensity);
            material.SetColor("_EmissionColor", finalColor);
        }
    }
}
