using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySound : MonoBehaviour
{

    private static AudioSource audioSource;

    bool getSEFlag;     //Pauseから受け取る変数用
    bool pauseflag = true;  //ポーズ状態か管理するためのフラグ

    void Start()
    {
        //AudioComponentを取得
        audioSource = GetComponent<AudioSource>();

        audioSource.Stop();
    }


    void Update()
    {
        getSEFlag = Pause.GetSEflag();

        if (getSEFlag == false) //もし getSEFlag が false なら
        {
            if (pauseflag == true)
            {
                pauseflag = false;
                if (Time.timeScale == 0)
                {
                    audioSource.Stop();

                    //Debug.Log("音がとまる");
                }
            }
        }
        else　   //もし getSEFlag が true なら
        {
            if (pauseflag == false)
            {
                pauseflag = true;
                if (Time.timeScale == 1)
                {
                    audioSource.Play();
                }
            }
        }
    }

    public static AudioSource GetEnemySE()
    {
        return audioSource;
    }
}
