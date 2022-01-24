using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstSelect : MonoBehaviour
{
    Button firstSelect;

    void Start()
    {
        firstSelect = GameObject.Find("Canvas/Panel/Retry").GetComponent<Button>();

        firstSelect.Select();
    }
}
