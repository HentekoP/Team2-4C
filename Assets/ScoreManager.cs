﻿using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{

    public GameObject score_object = null; // Textオブジェクト
    public int score_num = 0; // スコア変数

    // 初期化
    void Update()
    {

        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "Score:" + score_num;

        score_num += 1; // とりあえず1加算し続けてみる

    }

    // 更新
    void Start()
    {

    }
}