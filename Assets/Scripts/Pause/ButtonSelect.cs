using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelect : MonoBehaviour
{
    Button Retry;
    Button TitleBack;

    void Start()
    {
        //ボタンコンポーネント取得
        //Retry = GameObject.Find("/pausePanel/Retry").GetComponent<Button>();
        TitleBack = GameObject.Find("/pausePanel/TitleBack").GetComponent<Button>();

        //最初に選択状態にしたいボタンの設定
        Retry.Select();
    }
}
