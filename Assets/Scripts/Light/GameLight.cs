using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLight : MonoBehaviour
{
    [SerializeField] float maxIntensity;
    [SerializeField] float blinkSpeed;

    //光の点滅
    Light blinkLight;

    int flashAdjustValue = 7;

    void Start()
    {
        blinkLight = this.gameObject.GetComponent<Light>();
    }

    void Update()
    {
        blinkLight.intensity = Random.Range(0, maxIntensity);
    }
}