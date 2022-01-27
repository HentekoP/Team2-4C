using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    //入れたオブジェクトを消す
    [SerializeField]
    GameObject pausePanel;

    bool getRuleflag;

    //スタートボタンを押したかの判定
    bool pushFlag = true;

    private static bool SEFlag;

    private void Start()
    {
        pausePanel.SetActive(false);    //ポーズ画面を消す
        SEFlag = true;
    }

    void Update()
    {
        getRuleflag = Rule.GetRuleFlag();

        if (getRuleflag == true)
        {
            //Pキーか Start ボタンが押されたら
            if (Input.GetKeyDown(KeyCode.P) || Input.GetButton("Start"))
            {
                if (pushFlag == true)
                {
                    pushFlag = false;
                    SEFlag = false;
                    if (Time.timeScale == 1)    //ゲームが動いていたら
                    {
                        Time.timeScale = 0;     //ゲーム内の時間を止める
                        pausePanel.SetActive(true); //ポーズ画面を出す

                        //Debug.Log("止まっています");
                    }
                    else //Time.timeScale = 0だったら
                    {
                        Time.timeScale = 1;     //ゲーム内の時間を進める
                        pausePanel.SetActive(false);    //ポーズ画面を消す
                        SEFlag = true;

                        //Debug.Log("動き出しました");
                    }
                }
            }
            else //Startボタンが押されていないときの処理
            {
                pushFlag = true;

                //Debug.Log("Startボタンが押されていないとき");
            }
        }
    }

    public static bool GetSEflag()
    {
        return SEFlag;
    }
}