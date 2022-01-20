﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    [SerializeField]
    GameObject pausePanel;
    bool pushFlag = false;
    bool pushscene = true;

    private void Start()
    {
        pausePanel.SetActive(false);    //ポーズ画面を消す
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetButton("Start"))
        {
            if (pushFlag == true)
            {
                pushFlag = false;
                if (Time.timeScale == 1)    //ゲームが動いていたら
                {
                    Time.timeScale = 0;     //ゲーム内の時間を止める
                    pausePanel.SetActive(true); //ポーズ画面を出す
                    Debug.Log("止まっています");
                }
                else //Time.timeScale = 0だったら
                {
                    Time.timeScale = 1;     //ゲーム内の時間を進める
                    pausePanel.SetActive(false);    //ポーズ画面を消す
                    Debug.Log("動き出しました");

                }
            }
        }
        else //Startボタンが押されていないときの処理
        {
            pushFlag = true;
            Debug.Log("Startボタンが押されていないとき");
        }
    }
}