using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField]
    GameObject pausePanel;
    bool pushFlag = false;
    bool pushscene;

    private void Start()
    {
        pausePanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetButton("Start"))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pausePanel.SetActive(true);
            }
            else
            {
                pushFlag = true;
                Time.timeScale = 1;
                pausePanel.SetActive(false);
            }
        }
        else
        {
            pushFlag = false;
        }
    }
}