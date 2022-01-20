using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLight : MonoBehaviour
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
        if(blinkLight.intensity > maxIntensity / flashAdjustValue)
        {
            //ランダムに点滅させる
            blinkLight.intensity = Mathf.PerlinNoise(Time.time * blinkSpeed, 0) * maxIntensity;
        }
        else
        {
            //光の強さが変化する
            blinkLight.intensity = Random.Range(0, maxIntensity / 2);
        }
    }
}
