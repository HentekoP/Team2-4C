using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    //ゲームサウンド
    private AudioSource audioSource;
    public AudioClip sound1;

    //ゲームライト
    public GameObject gamelight;

    void Start()
    {
        //AudioComponentを取得
        audioSource = GetComponent<AudioSource>();

        //ゲームライト（オン）
        gamelight.SetActive(true);
    }

    void Update()
    {
        //もしBボタンが押されたら
        if (Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            //その時ゲームライトが（オン）なら
            if (gamelight.activeSelf)
            {
                Debug.Log("ボタンが押されている");
                //ゲームライト（オフ）
                gamelight.SetActive(false);
            }
            else
            {
                Debug.Log("もう一度押された");
                //ゲームサウンドを鳴らす
                audioSource.PlayOneShot(sound1);
                //ゲームライト（オン）
                gamelight.SetActive(true);
            }
        }
    }
}
