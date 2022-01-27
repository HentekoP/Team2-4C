using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSound : MonoBehaviour
{
    public static MainSound Instance
    {
        get; private set;
    }

    void Awake()
    {
        //もしオブジェクトが生成された場合
        if(Instance != null)
        {
            //オブジェクトを破棄する
            Destroy(gameObject);
            return;
        }
        //オブジェクトが1つも無い場合
        Instance = this;
        //オブジェクトをロードする
        DontDestroyOnLoad(gameObject);
    }
}
