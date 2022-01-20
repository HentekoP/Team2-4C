using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


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
        if (Input.GetButton("A")){
            Debug.Log("0");
        }
        if (Input.GetButton("B"))
        {
            Debug.Log("1");
        }
        if (Input.GetButton("X"))
        {
            Debug.Log("2");
        }
        if (Input.GetButton("Y"))
        {
            Debug.Log("3");
        }

        if(Input.GetAxis("Vertical") == 1)
        {
            Debug.Log("上");
        }else if(Input.GetAxis("Vertical") == -1)
        {
            Debug.Log("下");
        }

        if (Input.GetAxis("Vertical2") == 1)
        {
            Debug.Log("上");
        }
        else if (Input.GetAxis("Vertical2") == -1)
        {
            Debug.Log("下");
        }

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