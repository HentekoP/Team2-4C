using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blinker : MonoBehaviour
{
    public float speed = 1.0f;
    private Text text;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        //ゲームオブジェクト取得
        text = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //テキストカラーのアルファ値を変更する
        text.color = GetAlphaColor(text.color);
    }

    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        //Sin関数を使用（周期的な動きに有効）
        //Sin * アルファ値の 0～1 + 1～0 の値で変化する　
        //※点滅を途中までにする場合は右の値を1にする
        color.a = Mathf.Sin(time) * 0.9f + 1f;

        return color;
    }
}
