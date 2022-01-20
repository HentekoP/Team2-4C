using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dubug : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("A"))
        {
            Debug.Log("Aが押されました");

        }
        if(Input.GetAxis("Vertical") == 1){
            Debug.Log("1");
        }
    }
}
